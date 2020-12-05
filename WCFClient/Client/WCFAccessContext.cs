using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MSAccessCore;
using MSAccessCore.AccessDataModels;
using WCFCore.DataContracts;
using WCFCore.ServiceContracts;

namespace WCFClient.Client
{
    public class WCFAccessContext : IDataTransfer
    {
        #region fields

        private readonly IMapper mapper;
        private static string ConnectionString;

        /// <summary>
        /// Названия папок
        /// </summary>
        private enum SQLFolders
        {
            Users, UserInfos, Positions, Permissions, RequestTypes
        }

        #endregion
        #region ctor

        public WCFAccessContext()
        {
            mapper = InjectingCoreLibrary.MapperCore.ServerImplementation.ServerMapperCore.ServerMapper;

            if (!string.IsNullOrEmpty(ConnectionString))
            {
                return;
            }

            StringBuilder sb = new StringBuilder();

            sb.Append("Provider=");
            sb.Append(ConfigurationManager.AppSettings["MSAccessProvider"]);
            sb.Append(" Data Source=");
            sb.Append(ConfigurationManager.AppSettings["MSAccessDataSource"]);
            if (ConfigurationManager.AppSettings["MSAccessIntegratedSecurity"].Equals("True"))
            {
                sb.Append("Persist Security Info=False;");
            }
            else
            {
                sb.Append("Jet OLEDB:Database Password=");
                sb.Append(ConfigurationManager.AppSettings["MSAccessDataPassword"]);
            }
            ConnectionString = sb.ToString();
        }

        #endregion

        #region base SQL stored procedure realize -- доп возможности с SQL запросами

        /// <summary>
        /// Создать комманду для БД и при необходимости запустить
        /// </summary>
        /// <param name="connector">коннектор для БД</param>
        /// <param name="procedureFolder">Папка с файлом процедуры</param>
        /// <param name="procedureName">Имя процедуры (SQL файл)</param>
        /// <param name="doExecuteReader">Если True возвращает ридер из команды</param>
        /// <param name="parameters">Параметры в виде (ключ, объект) если null не добавляются</param>
        /// <returns>OleDbCommand команда или OleDbDataReader</returns>
        private object CreateCommand(AccessConnector connector,
                                                       string procedureFolder,
                                                       string procedureName,
                                                       Dictionary<string, object> parameters = null,
                                                       bool doExecuteReader = true)
        {
            OleDbCommand cmd = connector.GetCommand();
            cmd.CommandText = connector.GetStoreProcedure(procedureFolder, procedureName);

            if (!parameters.IsNull())
            {
                foreach (string key in parameters.Keys)
                {
                    cmd.Parameters.AddWithValue(key, parameters[key]);
                }
            }

            if (doExecuteReader)
            {
                return cmd.ExecuteReader();
            }
            else
            {
                return cmd;
            }
        }

        /// <summary>
        /// Вернуть коллекцию из ридера
        /// </summary>
        /// <typeparam name="ADType">Тип данных для ридера</typeparam>
        /// <param name="reader">ридер</param>
        /// <param name="mapMethodName">имя метода мапера</param>
        /// <returns>коллекция из моделей указанного типа</returns>
        private List<ADType> GetCollectionFromReader<ADType>(OleDbDataReader reader, string mapMethodName)
            where ADType : new()
        {
            List<ADType> models = new List<ADType>();
            MethodInfo method = GetType().GetRuntimeMethods().FirstOrDefault(m => m.Name.Equals(mapMethodName));
            while (reader.Read())
            {
                models.Add((ADType)method.Invoke(this, new object[] { reader }));
            }

            reader.Close();
            return models;
        }

        /// <summary>
        /// Вернуть модель из ридера
        /// </summary>
        /// <typeparam name="ADType">Тип данных для ридера</typeparam>
        /// <param name="reader">ридер</param>
        /// <param name="mapMethodName">имя метода мапера</param>
        /// <returns>модель указанного типа</returns>
        private ADType GetSingleFromReader<ADType>(OleDbDataReader reader, string mapMethodName)
            where ADType : new()
        {
            MethodInfo method = GetType().GetRuntimeMethods().FirstOrDefault(m => m.Name.Equals(mapMethodName));
            reader.Read();
            if (!reader.HasRows)
            {
                return default;
            }

            ADType model = (ADType)method.Invoke(this, new object[] { reader });
            reader.Close();
            return model;
        }

        #endregion

        #region users -- Реализовано
        public IEnumerable<UserDataContract> GetUsersCollection()
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            OleDbDataReader reader = (OleDbDataReader)CreateCommand(connector, nameof(SQLFolders.Users), nameof(GetUsersCollection));
            List<UserAD> models = GetCollectionFromReader<UserAD>(reader, nameof(MapUser));
            return mapper.Map<IEnumerable<UserDataContract>>(models);
        }
        public UserDataContract GetUserDataByLogin(string Login)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            OleDbDataReader reader = (OleDbDataReader)CreateCommand(connector, nameof(SQLFolders.Users), nameof(GetUserDataByLogin),
                new Dictionary<string, object> {
                    { "@Login", Login }
                });
            UserAD model = GetSingleFromReader<UserAD>(reader, nameof(MapUser));
            return mapper.Map<UserDataContract>(model);
        }
        public UserDataContract GetUserDataByID(Guid ID)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            OleDbDataReader reader = (OleDbDataReader)CreateCommand(connector, nameof(SQLFolders.Users), nameof(GetUserDataByLogin),
                new Dictionary<string, object> {
                    { "@ID", ID }
                });
            UserAD model = GetSingleFromReader<UserAD>(reader, nameof(MapUser));
            return mapper.Map<UserDataContract>(model);
        }
        public UserDataContract InsertUser(UserDataContract user)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            OleDbCommand cmd;
            Dictionary<string, object> parameters = new Dictionary<string, object>(){
                {"@ID", user.ID },
                {"@Login", user.Login },
                {"@Password", user.Password }
            };

            if (user.UserInfo.IsNull())
            {
                parameters.Add("@PositionID", user.Position.ID);
                cmd = (OleDbCommand)CreateCommand(connector, nameof(SQLFolders.Users), $"{nameof(InsertUser)}WithoutInfo", parameters, false);
            }
            else
            {
                Task.Run(() => InsertUserInfo(user.UserInfo));
                parameters.Add("@UserInfoID", user.UserInfo.ID);
                parameters.Add("@PositionID", user.Position.ID);
                cmd = (OleDbCommand)CreateCommand(connector, nameof(SQLFolders.Users), $"{nameof(InsertUser)}WithInfo", parameters, false);
            }

            if (!cmd.ExecuteNonQuery().Equals(0))
            {
                return user;
            }
            else
            {
                throw new FaultException("При добавлении пользователя произошла ошибка");
            }
        }
        public UserDataContract UpdateUser(UserDataContract user)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            OleDbCommand cmd;
            Dictionary<string, object> parameters = new Dictionary<string, object>(){
                { "@Login", user.Login },
                { "@Password", user.Password }
            };

            if (user.UserInfo.IsNull())
            {
                parameters.Add("@PositionID", user.Position.ID);
                cmd = (OleDbCommand)CreateCommand(connector, nameof(SQLFolders.Users), $"{nameof(UpdateUser)}WithoutInfo", parameters, false);
            }
            else
            {
                Task.Run(() => UpdateUserInfo(user.UserInfo));
                parameters.Add("@UserInfoID", user.UserInfo.ID);
                parameters.Add("@PositionID", user.Position.ID);
                cmd = (OleDbCommand)CreateCommand(connector, nameof(SQLFolders.Users), $"{nameof(UpdateUser)}WithInfo", parameters, false);
            }
            cmd.Parameters.AddWithValue("@ID", user.ID);
            if (!cmd.ExecuteNonQuery().Equals(0))
            {
                return user;
            }
            else
            {
                throw new FaultException("При изменении пользователя произошла ошибка");
            }
        }
        public int DeleteUser(UserDataContract user)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            OleDbCommand cmd = (OleDbCommand)CreateCommand(connector, nameof(SQLFolders.Users), nameof(DeleteUser),
                new Dictionary<string, object> { { "@ID", user.ID } }, false);

            int changes = cmd.ExecuteNonQuery();
            if (changes.Equals(0))
            {
                throw new FaultException("При удалении одного или нескольких пользователей произошла ошибка");
            }

            Task.Run(() => DeleteUserInfo(user.UserInfo));
            return changes;
        }

        /// <summary>
        /// Маппер из ридера модель сотрудника
        /// </summary>
        /// <param name="reader">ридер</param>
        /// <returns>модель сотрудника</returns>
        private UserAD MapUser(OleDbDataReader reader)
        {
            return new UserAD
            {
                ID = new Guid(reader.GetValue(0).ToString()),
                Login = reader.GetValue(1).ToString(),
                Password = reader.GetValue(2).ToString(),
                UserInfo = new UserInfoAD()
                {
                    ID = new Guid(reader.GetValue(3).ToString()),
                    FirstName = reader.GetValue(4).ToString(),
                    SecondName = reader.GetValue(5).ToString(),
                    LastName = reader.GetValue(6).ToString(),
                    ContactNumber = reader.GetValue(7).ToString()
                },
                Position = new PositionAD()
                {
                    ID = new Guid(reader.GetValue(8).ToString()),
                    Name = reader.GetValue(9).ToString(),
                    Description = reader.GetValue(10).ToString()
                }
            };
        }

        #endregion
        #region user infos -- Реализовано
        public UserInfoDataContract GetUserInfoByID(Guid ID)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            OleDbCommand cmd = connector.GetCommand();
            cmd.CommandText = connector.GetStoreProcedure(nameof(SQLFolders.UserInfos), nameof(GetUserInfoByID));
            cmd.Parameters.AddWithValue("@ID", ID);
            OleDbDataReader reader = cmd.ExecuteReader();

            if (!reader.HasRows)
            {
                return null;
            }

            reader.Read();
            UserInfoAD model = MapUserInfo(reader);
            return mapper.Map<UserInfoDataContract>(model);
        }
        public UserInfoDataContract InsertUserInfo(UserInfoDataContract userInfo)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            OleDbCommand cmd = connector.GetCommand();
            cmd.CommandText = connector.GetStoreProcedure(nameof(SQLFolders.UserInfos), nameof(InsertUserInfo));
            cmd.Parameters.AddWithValue("@ID", userInfo.ID);
            cmd.Parameters.AddWithValue("@FirstName", userInfo.FirstName.CheckDBNull());
            cmd.Parameters.AddWithValue("@SecondName", userInfo.SecondName.CheckDBNull());
            cmd.Parameters.AddWithValue("@LastName", userInfo.LastName.CheckDBNull());
            cmd.Parameters.AddWithValue("@ContactNumber", userInfo.ContactNumber.CheckDBNull());
            if (!cmd.ExecuteNonQuery().Equals(0))
            {
                //return GetUserInfoByID(userInfo.ID);
                return userInfo;
            }
            else
            {
                throw new FaultException("При добавлении доп информации пользователя произошла ошибка");
            }
        }
        public UserInfoDataContract UpdateUserInfo(UserInfoDataContract userInfo)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            OleDbCommand cmd = connector.GetCommand();
            cmd.CommandText = connector.GetStoreProcedure(nameof(SQLFolders.UserInfos), nameof(UpdateUserInfo));
            cmd.Parameters.AddWithValue("@FirstName", userInfo.FirstName.CheckDBNull());
            cmd.Parameters.AddWithValue("@SecondName", userInfo.SecondName.CheckDBNull());
            cmd.Parameters.AddWithValue("@LastName", userInfo.LastName.CheckDBNull());
            cmd.Parameters.AddWithValue("@ContactNumber", userInfo.ContactNumber.CheckDBNull());
            cmd.Parameters.AddWithValue("@ID", userInfo.ID);
            if (!cmd.ExecuteNonQuery().Equals(0))
            {
                //return GetUserInfoByID(userInfo.ID);
                return userInfo;
            }
            else
            {
                throw new FaultException("При изменении доп информации пользователя произошла ошибка");
            }
        }
        public int DeleteUserInfo(UserInfoDataContract userInfo)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            OleDbCommand cmd = connector.GetCommand();
            cmd.CommandText = connector.GetStoreProcedure(nameof(SQLFolders.UserInfos), nameof(DeleteUserInfo));
            cmd.Parameters.AddWithValue("@ID", userInfo.ID);

            int changes = cmd.ExecuteNonQuery();
            if (!changes.Equals(0))
            {
                return changes;
            }
            else
            {
                throw new FaultException("При удалении доп инфо пользователя произошла ошибка");
            }
        }

        /// <summary>
        /// Маппер из ридера модель инфо сотрудника
        /// </summary>
        /// <param name="reader">ридер</param>
        /// <returns>модель инфо сотрудника</returns>
        private UserInfoAD MapUserInfo(OleDbDataReader reader)
        {
            return new UserInfoAD()
            {
                ID = new Guid(reader.GetValue(0).ToString()),
                FirstName = reader.GetValue(1).ToString(),
                SecondName = reader.GetValue(2).ToString(),
                LastName = reader.GetValue(3).ToString(),
                ContactNumber = reader.GetValue(4).ToString()
            };
        }

        #endregion
        #region positions -- Реализовано
        public IEnumerable<PositionDataContract> GetPositionsCollection()
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            OleDbDataReader reader = (OleDbDataReader)CreateCommand(connector, nameof(SQLFolders.Positions), nameof(GetPositionsCollection));
            List<PositionAD> models = GetCollectionFromReader<PositionAD>(reader, nameof(MapPosition));
            return mapper.Map<IEnumerable<PositionDataContract>>(models);
        }
        public PositionDataContract GetPositionByID(Guid ID)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            OleDbDataReader reader = (OleDbDataReader)CreateCommand(connector, nameof(SQLFolders.Positions), nameof(GetPositionByID),
                new Dictionary<string, object> {
                    { "@ID", ID }
                });
            PositionAD model = GetSingleFromReader<PositionAD>(reader, nameof(MapPosition));
            return mapper.Map<PositionDataContract>(model);
        }
        public PositionDataContract GetFirstPositionByName(string Name)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            OleDbDataReader reader = (OleDbDataReader)CreateCommand(connector, nameof(SQLFolders.Positions), nameof(GetFirstPositionByName),
                new Dictionary<string, object> {
                    { "@Name", Name }
                });
            PositionAD model = GetSingleFromReader<PositionAD>(reader, nameof(MapPosition));
            return mapper.Map<PositionDataContract>(model);
        }
        public PositionDataContract InsertPosition(PositionDataContract position)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>(){
                {"@ID", position.ID },
                {"@Name", position.Name },
                {"@Description", position.Description }
            };
            OleDbCommand cmd = (OleDbCommand)CreateCommand(connector, nameof(SQLFolders.Positions), nameof(InsertPosition), parameters, false);

            if (!cmd.ExecuteNonQuery().Equals(0))
            {
                return position;
            }
            else
            {
                throw new FaultException("При добавлении должности произошла ошибка");
            }
        }
        public PositionDataContract UpdatePosition(PositionDataContract position)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>(){
                {"@Name", position.Name },
                {"@Description", position.Description },
                {"@ID", position.ID }
            };
            OleDbCommand cmd = (OleDbCommand)CreateCommand(connector, nameof(SQLFolders.Positions), nameof(UpdatePosition), parameters, false);

            if (!cmd.ExecuteNonQuery().Equals(0))
            {
                return position;
            }
            else
            {
                throw new FaultException("При изменении должности произошла ошибка");
            }
        }
        public int DeletePosition(PositionDataContract position)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            OleDbCommand cmd = (OleDbCommand)CreateCommand(connector, nameof(SQLFolders.Positions), nameof(DeletePosition),
                new Dictionary<string, object> { { "@ID", position.ID } }, false);

            int changes = cmd.ExecuteNonQuery();
            if (changes.Equals(0))
            {
                throw new FaultException("При удалении одной или нескольких должностей произошла ошибка");
            }

            return changes;
        }

        /// <summary>
        /// Маппер из ридера модель должности
        /// </summary>
        /// <param name="reader">ридер</param>
        /// <returns>модель должности</returns>
        private PositionAD MapPosition(OleDbDataReader reader)
        {
            return new PositionAD()
            {
                ID = new Guid(reader.GetValue(0).ToString()),
                Name = reader.GetValue(1).ToString(),
                Description = reader.GetValue(2).ToString()
            };
        }

        #endregion
        #region request types -- Реализовано
        public IEnumerable<RequestTypeDataContract> GetRequestTypeCollection()
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            OleDbDataReader reader = (OleDbDataReader)CreateCommand(connector, nameof(SQLFolders.RequestTypes), nameof(GetRequestTypeCollection));
            List<RequestTypeAD> models = GetCollectionFromReader<RequestTypeAD>(reader, nameof(MapRequestType));
            return mapper.Map<IEnumerable<RequestTypeDataContract>>(models);
        }
        public RequestTypeDataContract GetRequestTypeByID(Guid ID)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            OleDbDataReader reader = (OleDbDataReader)CreateCommand(connector, nameof(SQLFolders.RequestTypes), nameof(GetRequestTypeByID),
                new Dictionary<string, object> {
                    { "@ID", ID }
                });
            RequestTypeAD model = GetSingleFromReader<RequestTypeAD>(reader, nameof(MapRequestType));
            return mapper.Map<RequestTypeDataContract>(model);
        }
        public RequestTypeDataContract GetRequestTypeByName(string RequestName)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            OleDbDataReader reader = (OleDbDataReader)CreateCommand(connector, nameof(SQLFolders.RequestTypes), nameof(GetRequestTypeByName),
                new Dictionary<string, object> {
                    { "@RequestName", RequestName }
                });
            RequestTypeAD model = GetSingleFromReader<RequestTypeAD>(reader, nameof(MapRequestType));
            return mapper.Map<RequestTypeDataContract>(model);
        }
        public RequestTypeDataContract InsertRequestType(RequestTypeDataContract requestType)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>(){
                {"@ID", requestType.ID },
                {"@RequestName", requestType.RequestName },
                {"@Description", requestType.Description }
            };
            OleDbCommand cmd = (OleDbCommand)CreateCommand(connector, nameof(SQLFolders.RequestTypes), nameof(InsertRequestType), parameters, false);

            if (!cmd.ExecuteNonQuery().Equals(0))
            {
                return requestType;
            }
            else
            {
                throw new FaultException("При добавлении типа заявки произошла ошибка");
            }
        }
        public RequestTypeDataContract UpdateRequestType(RequestTypeDataContract requestType)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>(){
                {"@RequestName", requestType.RequestName },
                {"@Description", requestType.Description },
                {"@ID", requestType.ID }
            };
            OleDbCommand cmd = (OleDbCommand)CreateCommand(connector, nameof(SQLFolders.RequestTypes), nameof(UpdateRequestType), parameters, false);

            if (!cmd.ExecuteNonQuery().Equals(0))
            {
                return requestType;
            }
            else
            {
                throw new FaultException("При изменении типа заявки произошла ошибка");
            }
        }
        public int DeleteRequestType(RequestTypeDataContract requestType)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            OleDbCommand cmd = (OleDbCommand)CreateCommand(connector, nameof(SQLFolders.RequestTypes), nameof(DeleteRequestType),
                new Dictionary<string, object> { { "@ID", requestType.ID } }, false);

            int changes = cmd.ExecuteNonQuery();
            if (changes.Equals(0))
            {
                throw new FaultException("При удалении одного или нескольких типов заявки произошла ошибка");
            }

            return changes;
        }

        /// <summary>
        /// Маппер из ридера модель должности
        /// </summary>
        /// <param name="reader">ридер</param>
        /// <returns>модель должности</returns>
        private RequestTypeAD MapRequestType(OleDbDataReader reader)
        {
            return new RequestTypeAD()
            {
                ID = new Guid(reader.GetValue(0).ToString()),
                RequestName = reader.GetValue(1).ToString(),
                Description = reader.GetValue(2).ToString()
            };
        }

        #endregion
        #region permissions
        public IEnumerable<PermissionDataContract> GetPermissionsCollection()
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);

            OleDbCommand cmd = connector.GetCommand();
            cmd.CommandText = connector.GetStoreProcedure(nameof(SQLFolders.Permissions), nameof(GetPermissionsCollection));
            OleDbDataReader reader = cmd.ExecuteReader();

            List<PermissionAD> models = new List<PermissionAD>();
            while (reader.Read())
            {
                models.Add(MapPermission(reader));
            }

            return mapper.Map<IEnumerable<PermissionDataContract>>(models);
        }
        public IEnumerable<PermissionDataContract> GetPermissionsCollectionByPosition(PositionDataContract position)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);

            OleDbCommand cmd = connector.GetCommand();
            cmd.CommandText = connector.GetStoreProcedure(nameof(SQLFolders.Permissions), nameof(GetPermissionsCollectionByPosition));
            cmd.Parameters.AddWithValue("@ID", position.ID);
            OleDbDataReader reader = cmd.ExecuteReader();

            List<PermissionAD> models = new List<PermissionAD>();
            while (reader.Read())
            {
                models.Add(MapPermission(reader));
            }

            return mapper.Map<IEnumerable<PermissionDataContract>>(models);
        }
        public PermissionDataContract GetPermissionByID(Guid ID)
            => throw new NotImplementedException();
        public PermissionDataContract GetFirstPermissionByName(string Name)
            => throw new NotImplementedException();
        public PermissionDataContract InsertPermission(PermissionDataContract permission)
            => throw new NotImplementedException();
        public PermissionDataContract UpdatePermission(PermissionDataContract permission)
            => throw new NotImplementedException();
        public int DeletePermission(PermissionDataContract permission)
            => throw new NotImplementedException();

        /// <summary>
        /// Маппер из ридера модель разрешения
        /// </summary>
        /// <param name="reader">ридер</param>
        /// <returns>модель разрешения</returns>
        private PermissionAD MapPermission(OleDbDataReader reader)
        {
            return new PermissionAD()
            {
                ID = new Guid(reader.GetValue(0).ToString()),
                Name = reader.GetValue(1).ToString(),
                Description = reader.GetValue(2).ToString(),
            };
        }

        #endregion
        #region position permissions
        public IEnumerable<PositionPermissionDataContract> GetPositionPermissionsCollection()
            => throw new NotImplementedException();
        public IEnumerable<PermissionDataContract> GetPositionPermissionsCollectionByUserID(Guid UserID)
            => throw new NotImplementedException();
        public PositionPermissionDataContract InsertPositionPermissions(PositionDataContract position, PermissionDataContract permission)
            => throw new NotImplementedException();
        public int DeletePositionPermissions(Guid ID)
            => throw new NotImplementedException();

        #endregion
    }
}

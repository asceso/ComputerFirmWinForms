using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
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

        #region users -- Реализовано
        public IEnumerable<UserDataContract> GetUsersCollection()
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            connector.OpenConnect();
            OleDbCommand cmd = connector.GetCommand();
            cmd.CommandText = connector.GetStoreProcedure("Users", $"{nameof(GetUsersCollection)}.sql");
            OleDbDataReader reader = cmd.ExecuteReader();

            List<UserAD> models = new List<UserAD>();
            while (reader.Read())
            {
                models.Add(UserAccessFromReader(reader));
            }

            return mapper.Map<IEnumerable<UserDataContract>>(models);
        }
        public UserDataContract GetUserDataByLogin(string Login)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            connector.OpenConnect();
            OleDbCommand cmd = connector.GetCommand();
            cmd.CommandText = connector.GetStoreProcedure("Users", $"{nameof(GetUserDataByLogin)}.sql");
            cmd.Parameters.AddWithValue("@Login", Login);
            OleDbDataReader reader = cmd.ExecuteReader();

            if (!reader.HasRows)
            {
                return null;
            }

            reader.Read();
            UserAD model = UserAccessFromReader(reader);
            return mapper.Map<UserDataContract>(model);
        }
        public UserDataContract GetUserDataByID(Guid ID)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            connector.OpenConnect();
            OleDbCommand cmd = connector.GetCommand();
            cmd.CommandText = connector.GetStoreProcedure("Users", $"{nameof(GetUserDataByID)}.sql");
            cmd.Parameters.AddWithValue("@ID", ID);
            OleDbDataReader reader = cmd.ExecuteReader();

            if (!reader.HasRows)
            {
                return null;
            }

            reader.Read();
            UserAD model = UserAccessFromReader(reader);
            return mapper.Map<UserDataContract>(model);
        }
        public UserDataContract InsertUser(UserDataContract user)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            connector.OpenConnect();
            OleDbCommand cmd = connector.GetCommand();
            cmd.Parameters.AddWithValue("@ID", user.ID);
            cmd.Parameters.AddWithValue("@Login", user.Login);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            if (user.UserInfo.IsNull())
            {
                cmd.CommandText = connector.GetStoreProcedure("Users", $"{nameof(InsertUser)}WithoutInfo.sql");
                cmd.Parameters.AddWithValue("@PositionID", user.Position.ID);
            }
            else
            {
                Task.Run(() => InsertUserInfo(user.UserInfo));
                cmd.CommandText = connector.GetStoreProcedure("Users", $"{nameof(InsertUser)}WithInfo.sql");
                cmd.Parameters.AddWithValue("@UserInfoID", user.UserInfo.ID);
                cmd.Parameters.AddWithValue("@PositionID", user.Position.ID);
            }
            if (!cmd.ExecuteNonQuery().Equals(0))
            {
                //return GetUserDataByID(user.ID);
                return user;
            }
            else
            {
                throw new Exception("При добавлении пользователя произошла ошибка");
            }
        }
        public UserDataContract UpdateUser(UserDataContract user)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            connector.OpenConnect();
            OleDbCommand cmd = connector.GetCommand();
            cmd.Parameters.AddWithValue("@Login", user.Login);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            if (user.UserInfo.IsNull())
            {
                cmd.CommandText = connector.GetStoreProcedure("Users", $"{nameof(UpdateUser)}WithoutInfo.sql");
                cmd.Parameters.AddWithValue("@PositionID", user.Position.ID);
            }
            else
            {
                Task.Run(() => UpdateUserInfo(user.UserInfo));
                cmd.CommandText = connector.GetStoreProcedure("Users", $"{nameof(UpdateUser)}WithInfo.sql");
                cmd.Parameters.AddWithValue("@UserInfoID", user.UserInfo.ID);
                cmd.Parameters.AddWithValue("@PositionID", user.Position.ID);
            }
            cmd.Parameters.AddWithValue("@ID", user.ID);
            if (!cmd.ExecuteNonQuery().Equals(0))
            {
                //return GetUserDataByID(user.ID);
                return user;
            }
            else
            {
                throw new Exception("При изменении пользователя произошла ошибка");
            }
        }
        public int DeleteUser(UserDataContract user)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            connector.OpenConnect();
            OleDbCommand cmd = connector.GetCommand();
            cmd.CommandText = connector.GetStoreProcedure("Users", $"{nameof(DeleteUser)}.sql");
            cmd.Parameters.AddWithValue("@ID", user.ID);

            int changes = cmd.ExecuteNonQuery();
            if (!changes.Equals(0))
            {
                Task.Run(() => DeleteUserInfo(user.UserInfo));
                return changes;
            }
            else
            {
                throw new Exception("При удалении одного или нескольких пользователей произошла ошибка");
            }
        }

        private UserAD UserAccessFromReader(OleDbDataReader reader)
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
            connector.OpenConnect();
            OleDbCommand cmd = connector.GetCommand();
            cmd.CommandText = connector.GetStoreProcedure("UserInfos", $"{nameof(GetUserInfoByID)}.sql");
            cmd.Parameters.AddWithValue("@ID", ID);
            OleDbDataReader reader = cmd.ExecuteReader();

            if (!reader.HasRows)
            {
                return null;
            }

            reader.Read();
            UserInfoAD model = UserInfoAccessFromReader(reader);
            return mapper.Map<UserInfoDataContract>(model);
        }
        public UserInfoDataContract InsertUserInfo(UserInfoDataContract userInfo)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            connector.OpenConnect();
            OleDbCommand cmd = connector.GetCommand();
            cmd.CommandText = connector.GetStoreProcedure("UserInfos", $"{nameof(InsertUserInfo)}.sql");
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
                throw new Exception("При добавлении доп информации пользователя произошла ошибка");
            }
        }
        public UserInfoDataContract UpdateUserInfo(UserInfoDataContract userInfo)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            connector.OpenConnect();
            OleDbCommand cmd = connector.GetCommand();
            cmd.CommandText = connector.GetStoreProcedure("UserInfos", $"{nameof(UpdateUserInfo)}.sql");
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
                throw new Exception("При изменении доп информации пользователя произошла ошибка");
            }
        }
        public int DeleteUserInfo(UserInfoDataContract userInfo)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            connector.OpenConnect();
            OleDbCommand cmd = connector.GetCommand();
            cmd.CommandText = connector.GetStoreProcedure("UserInfos", $"{nameof(DeleteUserInfo)}.sql");
            cmd.Parameters.AddWithValue("@ID", userInfo.ID);

            int changes = cmd.ExecuteNonQuery();
            if (!changes.Equals(0))
            {
                return changes;
            }
            else
            {
                throw new Exception("При удалении доп инфо пользователя произошла ошибка");
            }
        }

        private UserInfoAD UserInfoAccessFromReader(OleDbDataReader reader)
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
            connector.OpenConnect();
            OleDbCommand cmd = connector.GetCommand();
            cmd.CommandText = connector.GetStoreProcedure("Positions", $"{nameof(GetPositionsCollection)}.sql");
            OleDbDataReader reader = cmd.ExecuteReader();

            List<PositionAD> models = new List<PositionAD>();
            while (reader.Read())
            {
                models.Add(PositionAccessFromReader(reader));
            }

            return mapper.Map<IEnumerable<PositionDataContract>>(models);
        }
        public PositionDataContract GetPositionByID(Guid ID)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            connector.OpenConnect();
            OleDbCommand cmd = connector.GetCommand();
            cmd.CommandText = connector.GetStoreProcedure("Positions", $"{nameof(GetPositionByID)}.sql");
            cmd.Parameters.AddWithValue("@ID", ID);
            OleDbDataReader reader = cmd.ExecuteReader();

            if (!reader.HasRows)
            {
                return null;
            }

            reader.Read();
            PositionAD model = PositionAccessFromReader(reader);
            return mapper.Map<PositionDataContract>(model);
        }
        public PositionDataContract GetFirstPositionByName(string Name)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            connector.OpenConnect();
            OleDbCommand cmd = connector.GetCommand();
            cmd.CommandText = connector.GetStoreProcedure("Positions", $"{nameof(GetFirstPositionByName)}.sql");
            cmd.Parameters.AddWithValue("@Name", Name.CheckDBNull());
            OleDbDataReader reader = cmd.ExecuteReader();

            if (!reader.HasRows)
            {
                return null;
            }

            reader.Read();
            PositionAD model = PositionAccessFromReader(reader);
            return mapper.Map<PositionDataContract>(model);
        }
        public PositionDataContract InsertPosition(PositionDataContract position)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            connector.OpenConnect();
            OleDbCommand cmd = connector.GetCommand();
            cmd.CommandText = connector.GetStoreProcedure("Positions", $"{nameof(InsertPosition)}.sql");
            cmd.Parameters.AddWithValue("@ID", position.ID);
            cmd.Parameters.AddWithValue("@Login", position.Name.CheckDBNull());
            cmd.Parameters.AddWithValue("@Password", position.Description.CheckDBNull());
            if (!cmd.ExecuteNonQuery().Equals(0))
            {
                //return GetPositionByID(position.ID);
                return position;
            }
            else
            {
                throw new Exception("При добавлении должности произошла ошибка");
            }
        }
        public PositionDataContract UpdatePosition(PositionDataContract position)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            connector.OpenConnect();
            OleDbCommand cmd = connector.GetCommand();
            cmd.CommandText = connector.GetStoreProcedure("Positions", $"{nameof(UpdatePosition)}.sql");
            cmd.Parameters.AddWithValue("@Login", position.Name.CheckDBNull());
            cmd.Parameters.AddWithValue("@Password", position.Description.CheckDBNull());
            cmd.Parameters.AddWithValue("@ID", position.ID);
            if (!cmd.ExecuteNonQuery().Equals(0))
            {
                //return GetPositionByID(position.ID);
                return position;
            }
            else
            {
                throw new Exception("При изменении должности произошла ошибка");
            }
        }
        public int DeletePosition(PositionDataContract position)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            connector.OpenConnect();
            OleDbCommand cmd = connector.GetCommand();
            cmd.CommandText = connector.GetStoreProcedure("Positions", $"{nameof(DeletePosition)}.sql");
            cmd.Parameters.AddWithValue("@ID", position.ID);

            int changes = cmd.ExecuteNonQuery();
            if (!changes.Equals(0))
            {
                return changes;
            }
            else
            {
                throw new Exception("При удалении одной или нескольких должностей произошла ошибка");
            }
        }

        private PositionAD PositionAccessFromReader(OleDbDataReader reader)
        {
            return new PositionAD()
            {
                ID = new Guid(reader.GetValue(0).ToString()),
                Name = reader.GetValue(1).ToString(),
                Description = reader.GetValue(2).ToString()
            };
        }
        #endregion
        #region permissions
        public IEnumerable<PermissionDataContract> GetPermissionsCollection()
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            connector.OpenConnect();
            OleDbCommand cmd = connector.GetCommand();
            cmd.CommandText = connector.GetStoreProcedure("Permissions", $"{nameof(GetPermissionsCollection)}.sql");
            OleDbDataReader reader = cmd.ExecuteReader();

            List<PermissionAD> models = new List<PermissionAD>();
            while (reader.Read())
            {
                models.Add(PermissionsAccessFromReader(reader));
            }

            return mapper.Map<IEnumerable<PermissionDataContract>>(models);
        }
        public IEnumerable<PermissionDataContract> GetPermissionsCollectionByPosition(PositionDataContract position)
        {
            using AccessConnector connector = new AccessConnector(ConnectionString);
            connector.OpenConnect();
            OleDbCommand cmd = connector.GetCommand();
            cmd.CommandText = connector.GetStoreProcedure("Permissions", $"{nameof(GetPermissionsCollectionByPosition)}.sql");
            cmd.Parameters.AddWithValue("@ID", position.ID);
            OleDbDataReader reader = cmd.ExecuteReader();

            List<PermissionAD> models = new List<PermissionAD>();
            while (reader.Read())
            {
                models.Add(PermissionsAccessFromReader(reader));
            }

            return mapper.Map<IEnumerable<PermissionDataContract>>(models);
        }
        public PermissionDataContract GetPermissionByID(Guid ID) => throw new NotImplementedException();
        public PermissionDataContract GetFirstPermissionByName(string Name) => throw new NotImplementedException();
        public PermissionDataContract InsertPermission(PermissionDataContract permission) => throw new NotImplementedException();
        public PermissionDataContract UpdatePermission(PermissionDataContract permission) => throw new NotImplementedException();
        public int DeletePermission(PermissionDataContract permission) => throw new NotImplementedException();

        private PermissionAD PermissionsAccessFromReader(OleDbDataReader reader)
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
        public int DeletePositionPermissions(Guid ID) => throw new NotImplementedException();
        #endregion
    }
}

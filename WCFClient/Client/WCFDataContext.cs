using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using AutoMapper;
using EFCore;
using EFCore.Entities;
using WCFCore.DataContracts;
using WCFCore.ServiceContracts;

namespace WCFClient.Client
{
    public class WCFDataContext : IDataTransfer
    {
        private readonly IMapper mapper;
        public WCFDataContext() => mapper = InjectingCoreLibrary.MapperCore.ServerImplementation.ServerMapperCore.ServerMapper;

        #region users
        public IEnumerable<UserDataContract> GetUsersCollection()
        {
            using EFDataContext context = new EFDataContext();

            System.Data.Entity.Infrastructure.DbQuery<User> users = context.Users
                .Include("Position")
                .Include("UserInfo");

            return mapper.Map<IEnumerable<UserDataContract>>(users);
        }
        public UserDataContract GetUserDataByID(Guid ID) => throw new NotImplementedException();
        public UserDataContract GetUserDataByLogin(string Login)
        {
            using EFDataContext context = new EFDataContext();

            User user = context.Users
                .Include("Position")
                .Include("UserInfo")
                .FirstOrDefault(u => u.Login.Equals(Login));

            if (user is null)
            {
                throw new FaultException("Пользователь не найден");
            }

            return mapper.Map<UserDataContract>(user);
        }
        public UserDataContract InsertUser(UserDataContract user)
        {
            using EFDataContext context = new EFDataContext();
            User newUser = mapper.Map<User>(user);
            if (newUser.UserInfoID.Equals(Guid.Empty))
            {
                newUser.UserInfo = null;
                newUser.UserInfoID = null;
            }
            newUser.Position = context.Positions.FirstOrDefault(p => p.ID.Equals(user.Position.ID));
            context.Users.Add(newUser);
            context.SaveChanges();
            return mapper.Map<UserDataContract>(newUser);
        }
        public UserDataContract UpdateUser(UserDataContract user)
        {
            using EFDataContext context = new EFDataContext();

            User dbUser = context.Users
                .Include("Position")
                .Include("UserInfo")
                .FirstOrDefault(u => u.ID.Equals(user.ID));

            dbUser.Position = context.Positions.FirstOrDefault(p => p.ID.Equals(user.Position.ID));

            UserInfo dbUserInfo = context.UserInfos.FirstOrDefault(ui => ui.ID.Equals(user.UserInfo.ID));
            if (dbUserInfo != null)
            {
                dbUser.UserInfo = mapper.Map<UserInfo>(user.UserInfo);
            }

            dbUser = mapper.Map<User>(user);

            context.SaveChanges();
            user = mapper.Map<UserDataContract>(dbUser);
            return user;
        }
        public int DeleteUser(UserDataContract user) => throw new NotImplementedException();
        #endregion
        #region positions
        public IEnumerable<PositionDataContract> GetPositionsCollection()
        {
            using EFDataContext context = new EFDataContext();
            List<Position> positions = context.Positions.ToList();
            return mapper.Map<IEnumerable<PositionDataContract>>(positions);
        }
        public PositionDataContract GetPositionByID(Guid ID) => throw new NotImplementedException();
        public PositionDataContract GetFirstPositionByName(string Name)
        {
            using EFDataContext context = new EFDataContext();
            return mapper.Map<PositionDataContract>(context.Positions.FirstOrDefault(p => p.Name.Equals(Name)));
        }
        public PositionDataContract InsertPosition(PositionDataContract position)
        {
            using EFDataContext context = new EFDataContext();
            Position newPosition = mapper.Map<Position>(position);
            context.Positions.Add(newPosition);
            context.SaveChanges();
            return mapper.Map<PositionDataContract>(newPosition);
        }
        public PositionDataContract UpdatePosition(PositionDataContract position) => throw new NotImplementedException();
        public int DeletePosition(PositionDataContract position) => throw new NotImplementedException();
        #endregion
        #region permissions
        public IEnumerable<PermissionDataContract> GetPermissionsCollection() => throw new NotImplementedException();
        public PermissionDataContract GetPermissionByID(Guid ID) => throw new NotImplementedException();
        public PermissionDataContract GetFirstPermissionByName(string Name) => throw new NotImplementedException();
        public PermissionDataContract InsertPermission(PermissionDataContract permission) => throw new NotImplementedException();
        public PermissionDataContract UpdatePermission(PermissionDataContract permission) => throw new NotImplementedException();
        public int DeletePermission(PermissionDataContract permission) => throw new NotImplementedException();
        #endregion
        #region position permissions
        public IEnumerable<PositionPermissionDataContract> GetPositionPermissionsCollection() => throw new NotImplementedException();
        public IEnumerable<PermissionDataContract> GetPositionPermissionsCollectionByUserID(Guid UserID) => throw new NotImplementedException();
        public PositionPermissionDataContract InsertPositionPermissions(PositionDataContract position, PermissionDataContract permission) => throw new NotImplementedException();
        #endregion


        public int DeletePositionPermissions(Guid ID) => throw new NotImplementedException();
        UserInfoDataContract IDataTransfer.GetUserInfoByID(Guid ID) => throw new NotImplementedException();
        UserInfoDataContract IDataTransfer.InsertUserInfo(UserInfoDataContract userInfo) => throw new NotImplementedException();
        UserInfoDataContract IDataTransfer.UpdateUserInfo(UserInfoDataContract userInfo) => throw new NotImplementedException();
        int IDataTransfer.DeleteUserInfo(UserInfoDataContract userInfo) => throw new NotImplementedException();
        IEnumerable<PermissionDataContract> IDataTransfer.GetPermissionsCollectionByPosition(PositionDataContract position) => throw new NotImplementedException();
    }
}

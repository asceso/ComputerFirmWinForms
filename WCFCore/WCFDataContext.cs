using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using AutoMapper;
using EFCore;
using WCFCore.DataContracts;
using WCFCore.ServiceContracts;
using WCFMapperService;

namespace WCFCore
{
    public class WCFDataContext : IDataTransfer
    {
        private IMapper mapper;
        public WCFDataContext() => mapper = ServerMapperCore.ServerMapper;

        #region users
        public IEnumerable<UserDataContract> GetUsersCollection() => throw new NotImplementedException();
        public UserDataContract GetUserDataByID(Guid ID) => throw new NotImplementedException();
        public UserDataContract GetUserDataByLogin(string Login)
        {
            using EFDataContext context = new EFDataContext();

            var user = context.Users
                .Include("Position")
                .Include("UserInfo")
                .FirstOrDefault(u=>u.Login.Equals(Login));

            if (user is null)
                throw new FaultException("Пользователь не найден");

            return mapper.Map<UserDataContract>(user);
        }
        public UserDataContract InsertUser(UserDataContract user) => throw new NotImplementedException();
        public int UpdateUser(UserDataContract user) => throw new NotImplementedException();
        public int DeleteUser(UserDataContract user) => throw new NotImplementedException();
        #endregion
        #region positions
        public IEnumerable<PositionDataContract> GetPositionsCollection() => throw new NotImplementedException();
        public PositionDataContract GetPositionByID(Guid ID) => throw new NotImplementedException();
        public PositionDataContract GetFirstPositionByName(string Name) => throw new NotImplementedException();
        public PositionDataContract InsertPosition(PositionDataContract position) => throw new NotImplementedException();
        public int UpdatePosition(PositionDataContract position) => throw new NotImplementedException();
        public int DeletePosition(PositionDataContract position) => throw new NotImplementedException();
        #endregion
        #region permissions
        public IEnumerable<PermissionDataContract> GetPermissionsCollection() => throw new NotImplementedException();
        public PermissionDataContract GetPermissionByID(Guid ID) => throw new NotImplementedException();
        public PermissionDataContract GetFirstPermissionByName(string Name) => throw new NotImplementedException();
        public PermissionDataContract InsertPermission(PermissionDataContract permission) => throw new NotImplementedException();
        public int UpdatePermission(PermissionDataContract permission) => throw new NotImplementedException();
        public int DeletePermission(PermissionDataContract permission) => throw new NotImplementedException();
        #endregion
        #region position permissions
        public IEnumerable<PositionPermissionDataContract> GetPositionPermissionsCollection() => throw new NotImplementedException();
        public IEnumerable<PermissionDataContract> GetPositionPermissionsCollectionByUserID(Guid UserID) => throw new NotImplementedException();
        public int InsertPositionPermissions(PositionDataContract position, PermissionDataContract permission) => throw new NotImplementedException();
        public int DeletePositionPermissions(Guid ID) => throw new NotImplementedException();
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Channels;
using WCFCore.DataContracts;
using WCFCore.ServiceContracts;

namespace WCFCore
{
    public class ComFirmClient : ClientBase<IDataTransfer>, IDataTransfer
    {
        public ComFirmClient(Binding binding, EndpointAddress address) : base(binding, address) { }

        #region users
        public IEnumerable<UserDataContract> GetUsersCollection() => Channel.GetUsersCollection();
        public UserDataContract GetUserDataByID(Guid ID) => Channel.GetUserDataByID(ID);
        public UserDataContract GetUserDataByLogin(string Login) => Channel.GetUserDataByLogin(Login);
        public UserDataContract InsertUser(UserDataContract user) => Channel.InsertUser(user);
        public int UpdateUser(UserDataContract user) => Channel.UpdateUser(user);
        public int DeleteUser(UserDataContract user) => Channel.DeleteUser(user);
        #endregion
        #region positions
        public IEnumerable<PositionDataContract> GetPositionsCollection() => Channel.GetPositionsCollection();
        public PositionDataContract GetPositionByID(Guid ID) => Channel.GetPositionByID(ID);
        public PositionDataContract GetFirstPositionByName(string Name) => Channel.GetFirstPositionByName(Name);
        public PositionDataContract InsertPosition(PositionDataContract position) => Channel.InsertPosition(position);
        public int UpdatePosition(PositionDataContract position) => Channel.UpdatePosition(position);
        public int DeletePosition(PositionDataContract position) => Channel.DeletePosition(position);
        #endregion
        #region permissions
        public IEnumerable<PermissionDataContract> GetPermissionsCollection() => Channel.GetPermissionsCollection();
        public PermissionDataContract GetPermissionByID(Guid ID) => Channel.GetPermissionByID(ID);
        public PermissionDataContract GetFirstPermissionByName(string Name) => Channel.GetFirstPermissionByName(Name);
        public PermissionDataContract InsertPermission(PermissionDataContract permission) => Channel.InsertPermission(permission);
        public int UpdatePermission(PermissionDataContract permission) => Channel.UpdatePermission(permission);
        public int DeletePermission(PermissionDataContract permission) => Channel.DeletePermission(permission);
        #endregion
        #region position permissions
        public IEnumerable<PositionPermissionDataContract> GetPositionPermissionsCollection() => Channel.GetPositionPermissionsCollection();
        public IEnumerable<PermissionDataContract> GetPositionPermissionsCollectionByUserID(Guid UserID) => Channel.GetPositionPermissionsCollectionByUserID(UserID);
        public int InsertPositionPermissions(PositionDataContract position, PermissionDataContract permission) => Channel.InsertPositionPermissions(position, permission);
        public int DeletePositionPermissions(Guid ID) => Channel.DeletePositionPermissions(ID);
        #endregion
    }
}

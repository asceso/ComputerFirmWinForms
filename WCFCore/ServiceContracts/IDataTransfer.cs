using System;
using System.Collections.Generic;
using System.ServiceModel;
using WCFCore.DataContracts;

namespace WCFCore.ServiceContracts
{
    [ServiceContract]
    public interface IDataTransfer
    {
        #region users
        [OperationContract]
        IEnumerable<UserDataContract> GetUsersCollection();

        [OperationContract]
        UserDataContract GetUserDataByID(Guid ID);

        [OperationContract]
        UserDataContract GetUserDataByLogin(string Login);

        [OperationContract]
        UserDataContract InsertUser(UserDataContract user);

        [OperationContract]
        int UpdateUser(UserDataContract user);

        [OperationContract]
        int DeleteUser(UserDataContract user);
        #endregion
        #region positions
        [OperationContract]
        IEnumerable<PositionDataContract> GetPositionsCollection();

        [OperationContract]
        PositionDataContract GetPositionByID(Guid ID);

        [OperationContract]
        PositionDataContract GetFirstPositionByName(string Name);

        [OperationContract]
        PositionDataContract InsertPosition(PositionDataContract position);

        [OperationContract]
        int UpdatePosition(PositionDataContract position);

        [OperationContract]
        int DeletePosition(PositionDataContract position);
        #endregion
        #region permissions
        [OperationContract]
        IEnumerable<PermissionDataContract> GetPermissionsCollection();

        [OperationContract]
        PermissionDataContract GetPermissionByID(Guid ID);

        [OperationContract]
        PermissionDataContract GetFirstPermissionByName(string Name);

        [OperationContract]
        PermissionDataContract InsertPermission(PermissionDataContract permission);

        [OperationContract]
        int UpdatePermission(PermissionDataContract permission);

        [OperationContract]
        int DeletePermission(PermissionDataContract permission);
        #endregion
        #region position permissions
        [OperationContract]
        IEnumerable<PositionPermissionDataContract> GetPositionPermissionsCollection();

        [OperationContract]
        IEnumerable<PermissionDataContract> GetPositionPermissionsCollectionByUserID(Guid UserID);

        [OperationContract]
        int InsertPositionPermissions(PositionDataContract position, PermissionDataContract permission);

        [OperationContract]
        int DeletePositionPermissions(Guid ID);
        #endregion
    }
}

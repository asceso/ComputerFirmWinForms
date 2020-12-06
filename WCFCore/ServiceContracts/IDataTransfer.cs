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
        UserDataContract UpdateUser(UserDataContract user);

        [OperationContract]
        int DeleteUser(UserDataContract user);

        #endregion
        #region user infos

        [OperationContract]
        UserInfoDataContract GetUserInfoByID(Guid ID);

        [OperationContract]
        UserInfoDataContract InsertUserInfo(UserInfoDataContract userInfo);

        [OperationContract]
        UserInfoDataContract UpdateUserInfo(UserInfoDataContract userInfo);

        [OperationContract]
        int DeleteUserInfo(UserInfoDataContract userInfo);

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
        PositionDataContract UpdatePosition(PositionDataContract position);

        [OperationContract]
        int DeletePosition(PositionDataContract position);

        #endregion
        #region request types

        [OperationContract]
        IEnumerable<RequestTypeDataContract> GetRequestTypeCollection();

        [OperationContract]
        RequestTypeDataContract GetRequestTypeByID(Guid ID);

        [OperationContract]
        RequestTypeDataContract GetRequestTypeByName(string Name);

        [OperationContract]
        RequestTypeDataContract InsertRequestType(RequestTypeDataContract requestType);

        [OperationContract]
        RequestTypeDataContract UpdateRequestType(RequestTypeDataContract requestType);

        [OperationContract]
        int DeleteRequestType(RequestTypeDataContract requestType);

        #endregion
        #region permissions

        [OperationContract]
        IEnumerable<PermissionDataContract> GetPermissionsCollection();

        [OperationContract]
        IEnumerable<PermissionDataContract> GetPermissionsCollectionByPosition(PositionDataContract position);

        [OperationContract]
        PermissionDataContract GetPermissionByID(Guid ID);

        [OperationContract]
        PermissionDataContract GetFirstPermissionByName(string Name);

        [OperationContract]
        PermissionDataContract InsertPermission(PermissionDataContract permission);

        [OperationContract]
        PermissionDataContract UpdatePermission(PermissionDataContract permission);

        [OperationContract]
        int DeletePermission(PermissionDataContract permission);

        #endregion
        #region position permissions

        [OperationContract]
        IEnumerable<PositionPermissionDataContract> GetPositionPermissionsCollection();

        [OperationContract]
        IEnumerable<PermissionDataContract> GetPositionPermissionsCollectionByUserID(Guid UserID);

        [OperationContract]
        PositionPermissionDataContract InsertPositionPermissions(PositionDataContract position, PermissionDataContract permission);

        [OperationContract]
        int DeletePositionPermissions(Guid ID);

        #endregion
        #region clients
        [OperationContract]
        IEnumerable<ClientDataContract> GetClientCollection();

        [OperationContract]
        ClientDataContract GetClientByID(Guid ID);

        [OperationContract]
        ClientDataContract InsertClient(ClientDataContract client);

        [OperationContract]
        ClientDataContract UpdateClient(ClientDataContract client);

        [OperationContract]
        int DeleteClient(ClientDataContract client);
        #endregion
    }
}

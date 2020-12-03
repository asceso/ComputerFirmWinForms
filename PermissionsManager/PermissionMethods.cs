using System.Collections.Generic;
using System.Linq;
using ClientDataServices;
using CoreClient.ShellModels;
using InjectingCoreLibrary.MapperCore.ClientImplementation;
using Ninject;
using WCFCore.DataContracts;

namespace PermissionsManager
{
    public class PermissionMethods : IPermissionInject
    {
        #region Fields
        private static UserModel CurrentUser;
        private static List<PermissionModel> UserPermissions;
        #endregion
        #region Ctor
        public PermissionMethods() { }
        #endregion
        #region Registering
        public void RegisterPermissionsForUser(IKernel kernel, UserModel user)
        {
            CurrentUser = user;
            IMapperInject mapper = kernel.Get<IMapperInject>();
            UserPermissions = mapper.Map<List<PermissionDataContract>, List<PermissionModel>>(
                PermissionsService.GetPermissionsCollectionByPosition(mapper
                .Map<PositionModel, PositionDataContract>(user.Position)).Result.ToList());
        }
        #endregion
        #region CheckPermission
        public bool IsHasPermission(PermissionModel permission)
        {
            if (CurrentUser.Login.Equals("admin"))
            {
                return true;
            }

            foreach (PermissionModel item in UserPermissions)
            {
                if (item.Equals(permission))
                {
                    return true;
                }
            }

            return false;
        }
        public bool IsHasPermission(string permissionName)
        {
            if (CurrentUser.Login.Equals("admin"))
            {
                return true;
            }

            foreach (PermissionModel item in UserPermissions)
            {
                if (item.Name.Equals(permissionName))
                {
                    return true;
                }
            }

            return false;
        }
        #endregion
    }
}

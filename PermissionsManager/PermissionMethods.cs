using System.Collections.Generic;
using System.Linq;
using ApplicationModels;
using ClientDataServices;
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
        #region Registering
        /// <summary>
        /// Регистрация разрешений для текущего пользователя
        /// </summary>
        /// <param name="kernel">Ядро ninject</param>
        /// <param name="user">Пользователь</param>
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
        /// <summary>
        /// Проверка текущего пользователя на разрешение через модель
        /// </summary>
        /// <param name="permission">Модель разрешения</param>
        /// <returns>True если у пользователя есть разрешение</returns>
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

        /// <summary>
        /// Проверка текущего пользователя на разрешение через имя разрешения
        /// </summary>
        /// <param name="permissionName">Имя разрешения</param>
        /// <returns>True если у пользователя есть разрешение</returns>
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

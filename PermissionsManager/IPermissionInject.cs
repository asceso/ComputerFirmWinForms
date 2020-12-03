using ApplicationModels;
using Ninject;

namespace PermissionsManager
{
    public interface IPermissionInject
    {
        void RegisterPermissionsForUser(IKernel kernel, UserModel user);
        bool IsHasPermission(PermissionModel permission);
        bool IsHasPermission(string permissionName);
    }
}

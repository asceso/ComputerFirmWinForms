using System;
using System.Threading.Tasks;
using WCFCore.DataContracts;
using WCFProxy.Proxy;

namespace ClientDataServices
{
    /// <summary>
    /// Методы доступа к связям разрешений и должностей
    /// </summary>
    public static class PositionPermissionService
    {
        /// <summary>
        /// Добавить связь разрешение - должность
        /// </summary>
        /// <param name="position">должность</param>
        /// <param name="permission">разрешение</param>
        /// <returns>контракт данных со связью</returns>
        public static async Task<PositionPermissionDataContract> InsertPositionPermissions(PositionDataContract position, PermissionDataContract permission)
            => await TunellProxy.UseTunellProxy(client => client.InsertPositionPermissions(position, permission));

        /// <summary>
        /// Удалить связь разрешение - должность
        /// </summary>
        /// <param name="ID">ИД записи</param>
        /// <returns>кол-во удаленных записей</returns>
        public static async Task<int> DeletePositionPermissions(Guid ID)
            => await TunellProxy.UseTunellProxy(client => client.DeletePositionPermissions(ID));
    }
}

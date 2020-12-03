using System.Collections.Generic;
using System.Threading.Tasks;
using WCFCore.DataContracts;
using WCFProxy.Proxy;

namespace ClientDataServices
{
    public class PermissionsService
    {
        /// <summary>
        /// Получить список всех разрешений
        /// </summary>
        /// <returns>список разрешений</returns>
        public static async Task<IEnumerable<PermissionDataContract>> GetPermissionsCollection()
            => await TunellProxy.UseTunellProxy(client => client.GetPermissionsCollection());

        /// <summary>
        /// Получить список разрешений для должности
        /// </summary>
        /// <param name="position">должность</param>
        /// <returns>список разрешений</returns>
        public static async Task<IEnumerable<PermissionDataContract>> GetPermissionsCollectionByPosition(PositionDataContract position)
            => await TunellProxy.UseTunellProxy(client => client.GetPermissionsCollectionByPosition(position));
    }
}

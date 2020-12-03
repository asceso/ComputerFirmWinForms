using System.Collections.Generic;
using System.Threading.Tasks;
using WCFCore.DataContracts;
using WCFProxy.Proxy;

namespace ClientDataServices
{
    public class PermissionsService
    {
        public static async Task<IEnumerable<PermissionDataContract>> GetPermissionsCollection()
            => await TunellProxy.UseTunellProxy(client => client.GetPermissionsCollection());
        public static async Task<IEnumerable<PermissionDataContract>> GetPermissionsCollectionByPosition(PositionDataContract position)
            => await TunellProxy.UseTunellProxy(client => client.GetPermissionsCollectionByPosition(position));
    }
}

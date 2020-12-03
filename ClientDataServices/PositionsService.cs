using System.Collections.Generic;
using System.Threading.Tasks;
using WCFCore.DataContracts;
using WCFProxy.Proxy;

namespace ClientDataServices
{
    public static class PositionsService
    {
        public static async Task<IEnumerable<PositionDataContract>> GetPositionsCollection()
            => await TunellProxy.UseTunellProxy(client => client.GetPositionsCollection());
        public static async Task<PositionDataContract> GetFirstPositionByName(string name)
            => await TunellProxy.UseTunellProxy(client => client.GetFirstPositionByName(name));
        public static async Task<PositionDataContract> InsertPosition(PositionDataContract position)
            => await TunellProxy.UseTunellProxy(client => client.InsertPosition(position));
    }
}

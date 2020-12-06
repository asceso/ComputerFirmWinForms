using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFCore.DataContracts;
using WCFProxy.Proxy;

namespace ClientDataServices
{
    public class ClientsService
    {
        public static async Task<IEnumerable<ClientDataContract>> GetClientsCollection()
            => await TunellProxy.UseTunellProxy(client => client.GetClientCollection());
        public static async Task<ClientDataContract> InsertClient(ClientDataContract clientModel)
            => await TunellProxy.UseTunellProxy(client => client.InsertClient(clientModel));
        public static async Task<ClientDataContract> UpdateClient(ClientDataContract clientModel)
            => await TunellProxy.UseTunellProxy(client => client.UpdateClient(clientModel));
        public static async Task<int> DeleteClient(ClientDataContract clientModel)
            => await TunellProxy.UseTunellProxy(client => client.DeleteClient(clientModel));
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using WCFCore.DataContracts;
using WCFProxy.Proxy;

namespace ClientDataServices
{
    /// <summary>
    /// Методы доступа к записям клиентов
    /// </summary>
    public static class ClientsService
    {
        /// <summary>
        /// Получить список клиентов
        /// </summary>
        /// <returns>список клиентов</returns>
        public static async Task<IEnumerable<ClientDataContract>> GetClientsCollection()
            => await TunellProxy.UseTunellProxy(client => client.GetClientCollection());

        /// <summary>
        /// Добавить клиента
        /// </summary>
        /// <param name="clientModel">модель клиента</param>
        /// <returns>измененная модель клиента</returns>
        public static async Task<ClientDataContract> InsertClient(ClientDataContract clientModel)
            => await TunellProxy.UseTunellProxy(client => client.InsertClient(clientModel));

        /// <summary>
        /// Изменить клиента
        /// </summary>
        /// <param name="clientModel">модель</param>
        /// <returns>измененная модель</returns>
        public static async Task<ClientDataContract> UpdateClient(ClientDataContract clientModel)
            => await TunellProxy.UseTunellProxy(client => client.UpdateClient(clientModel));

        /// <summary>
        /// Удалить клиента
        /// </summary>
        /// <param name="clientModel">модель</param>
        /// <returns>кол-во измененных записей</returns>
        public static async Task<int> DeleteClient(ClientDataContract clientModel)
            => await TunellProxy.UseTunellProxy(client => client.DeleteClient(clientModel));
    }
}

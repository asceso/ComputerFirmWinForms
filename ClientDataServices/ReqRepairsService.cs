using System.Collections.Generic;
using System.Threading.Tasks;
using WCFCore.DataContracts;
using WCFProxy.Proxy;

namespace ClientDataServices
{
    /// <summary>
    /// Методы доступа к заявкам ремонта
    /// </summary>
    public static class ReqRepairsService
    {
        /// <summary>
        /// Получить список всех заявок на ремонт
        /// </summary>
        /// <returns>список заявок на ремонт</returns>
        public static async Task<IEnumerable<RepairsRequestDataContract>> GetRepairsRequestCollection()
            => await TunellProxy.UseTunellProxy(client => client.GetRepairsRequestCollection());
    }
}

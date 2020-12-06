using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WCFCore.DataContracts;
using WCFProxy.Proxy;

namespace ClientDataServices
{
    /// <summary>
    /// Методы доступа связанные с типами заявок
    /// </summary>
    public static class RequestTypesService
    {
        /// <summary>
        /// Получить список типов зявок
        /// </summary>
        /// <returns>IEnumerable типов зявок</returns>
        public static async Task<IEnumerable<RequestTypeDataContract>> GetRequestTypeCollection()
            => await TunellProxy.UseTunellProxy(client => client.GetRequestTypeCollection());

        /// <summary>
        /// Первый тип заявки по вводимому имени
        /// </summary>
        /// <param name="name">Имя тип заявки</param>
        /// <returns>Модель тип заявки</returns>
        public static async Task<RequestTypeDataContract> GetRequestTypeByName(string name)
            => await TunellProxy.UseTunellProxy(client => client.GetRequestTypeByName(name));

        /// <summary>
        /// Первый тип заявки по ID
        /// </summary>
        /// <param name="ID">ID тип заявки</param>
        /// <returns>Модель тип заявки</returns>
        public static async Task<RequestTypeDataContract> GetRequestTypeByID(Guid ID)
            => await TunellProxy.UseTunellProxy(client => client.GetRequestTypeByID(ID));

        /// <summary>
        /// Добавить тип заявки
        /// </summary>
        /// <param name="position">тип заявки</param>
        /// <returns>Добавленный тип заявки</returns>
        public static async Task<RequestTypeDataContract> InsertRequestType(RequestTypeDataContract requestType)
            => await TunellProxy.UseTunellProxy(client => client.InsertRequestType(requestType));

        /// <summary>
        /// Изменить тип заявки
        /// </summary>
        /// <param name="position">тип заявки</param>
        /// <returns>Измененнный тип заявки</returns>
        public static async Task<RequestTypeDataContract> UpdateRequestType(RequestTypeDataContract requestType)
            => await TunellProxy.UseTunellProxy(client => client.UpdateRequestType(requestType));

        /// <summary>
        /// Удалить тип заявки
        /// </summary>
        /// <param name="position">тип заявки</param>
        /// <returns>кол-во удаленных типов заявки</returns>
        public static async Task<int> DeleteRequestType(RequestTypeDataContract requestType)
            => await TunellProxy.UseTunellProxy(client => client.DeleteRequestType(requestType));
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WCFCore.DataContracts;
using WCFProxy.Proxy;

namespace ClientDataServices
{
    /// <summary>
    /// Методы доступа связанные с должностями
    /// </summary>
    public static class PositionsService
    {
        /// <summary>
        /// Получить список должностей
        /// </summary>
        /// <returns>IEnumerable должностей</returns>
        public static async Task<IEnumerable<PositionDataContract>> GetPositionsCollection()
            => await TunellProxy.UseTunellProxy(client => client.GetPositionsCollection());

        /// <summary>
        /// Первая должность по вводимому имени
        /// </summary>
        /// <param name="name">Имя должности</param>
        /// <returns>Модель должности</returns>
        public static async Task<PositionDataContract> GetFirstPositionByName(string name)
            => await TunellProxy.UseTunellProxy(client => client.GetFirstPositionByName(name));

        /// <summary>
        /// Первая должность по ID
        /// </summary>
        /// <param name="ID">ID должности</param>
        /// <returns>Модель должности</returns>
        public static async Task<PositionDataContract> GetPositionByID(Guid ID)
            => await TunellProxy.UseTunellProxy(client => client.GetPositionByID(ID));

        /// <summary>
        /// Добавить должность
        /// </summary>
        /// <param name="position">Должность</param>
        /// <returns>Добавленная должность</returns>
        public static async Task<PositionDataContract> InsertPosition(PositionDataContract position)
            => await TunellProxy.UseTunellProxy(client => client.InsertPosition(position));

        /// <summary>
        /// Изменить должность
        /// </summary>
        /// <param name="position">должность</param>
        /// <returns>Измененнная должность</returns>
        public static async Task<PositionDataContract> UpdatePosition(PositionDataContract position)
            => await TunellProxy.UseTunellProxy(client => client.UpdatePosition(position));

        /// <summary>
        /// Удалить должность
        /// </summary>
        /// <param name="position">должность</param>
        /// <returns>кол-во удаленных должностей</returns>
        public static async Task<int> DeletePosition(PositionDataContract position)
            => await TunellProxy.UseTunellProxy(client => client.DeletePosition(position));
    }
}

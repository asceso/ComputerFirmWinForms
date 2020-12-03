using System;

namespace ApplicationModels
{
    /// <summary>
    /// Модель прайс листа
    /// </summary>
    public class PriceListModel
    {
        /// <summary>
        /// ИД
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// Ссылка на склад
        /// </summary>
        public WarehouseModel Warehouse { get; set; }

        /// <summary>
        /// Имя валюты
        /// </summary>
        public string CurrencyName { get; set; }

        /// <summary>
        /// Значение
        /// </summary>
        public int PositionValue { get; set; }
    }
}

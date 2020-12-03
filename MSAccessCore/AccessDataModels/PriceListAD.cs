using System;

namespace MSAccessCore.AccessDataModels
{
    /// <summary>
    /// Модель прайс листа
    /// </summary>
    public class PriceListAD
    {
        /// <summary>
        /// ИД
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// Ссылка на склад
        /// </summary>
        public WarehouseAD Warehouse { get; set; }

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

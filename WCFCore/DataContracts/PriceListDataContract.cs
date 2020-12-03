using System;
using System.Runtime.Serialization;

namespace WCFCore.DataContracts
{
    [DataContract]
    /// <summary>
    /// Модель прайс листа
    /// </summary>
    public class PriceListDataContract
    {
        [DataMember]
        /// <summary>
        /// ИД
        /// </summary>
        public Guid ID { get; set; }

        [DataMember]
        /// <summary>
        /// Ссылка на склад
        /// </summary>
        public WarehouseDataContract Warehouse { get; set; }

        [DataMember]
        /// <summary>
        /// Имя валюты
        /// </summary>
        public string CurrencyName { get; set; }

        [DataMember]
        /// <summary>
        /// Значение
        /// </summary>
        public int PositionValue { get; set; }
    }
}

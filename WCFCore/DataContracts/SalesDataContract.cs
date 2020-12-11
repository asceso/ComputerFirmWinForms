using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace WCFCore.DataContracts
{
    /// <summary>
    /// Модель записи продаж
    /// </summary>
    [DataContract]
    public class SalesDataContract
    {
        /// <summary>
        /// ИД записи
        /// </summary>
        [DataMember]
        public Guid ID { get; set; }

        /// <summary>
        /// Номер продажи
        /// </summary>
        [DataMember]
        public string SaleNumber { get; set; }

        /// <summary>
        /// Дата продажи
        /// </summary>
        [DataMember]
        public DateTime SaleDate { get; set; }

        /// <summary>
        /// Ссылка на продавца
        /// </summary>
        [DataMember]
        public UserDataContract Seller { get; set; }

        /// <summary>
        /// Ссылка на прайс лист
        /// </summary>
        [DataMember]
        public PriceListDataContract PriceList { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        [DataMember]
        public int PositionCount { get; set; }

        /// <summary>
        /// Закрыта или нет
        /// </summary>
        [DataMember]
        public bool IsClosed { get; set; }
    }
}

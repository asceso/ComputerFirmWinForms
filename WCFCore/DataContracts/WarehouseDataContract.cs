using System;
using System.Runtime.Serialization;

namespace WCFCore.DataContracts
{
    [DataContract]
    /// <summary>
    /// Склад
    /// </summary>
    public class WarehouseDataContract
    {
        [DataMember]
        /// <summary>
        /// Дата поступления на склад
        /// </summary>
        public DateTime AdmissionDate { get; set; }

        [DataMember]
        /// <summary>
        /// Сотрудник принявший на склад
        /// </summary>
        public UserDataContract User { get; set; }

        [DataMember]
        /// <summary>
        /// Количество позиции
        /// </summary>
        public int PositionCount { get; set; }

        [DataMember]
        /// <summary>
        /// Наименование позиции
        /// </summary>
        public string PositionName { get; set; }

        [DataMember]
        /// <summary>
        /// Описание позиции
        /// </summary>
        public string PositionDescription { get; set; }
    }
}

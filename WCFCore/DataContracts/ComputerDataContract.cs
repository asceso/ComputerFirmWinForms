using System;
using System.Runtime.Serialization;

namespace WCFCore.DataContracts
{
    [DataContract]
    /// <summary>
    /// Сборка компьютера
    /// </summary>
    public class ComputerDataContract
    {
        [DataMember]
        /// <summary>
        /// ИД Записи
        /// </summary>
        public Guid ID { get; set; }

        [DataMember]
        /// <summary>
        /// CPU - процессор
        /// </summary>
        public string CPU { get; set; }

        [DataMember]
        /// <summary>
        /// RAM - оперативная память
        /// </summary>
        public string RAM { get; set; }

        [DataMember]
        /// <summary>
        /// HDD - жесткий диск
        /// </summary>
        public string HDD { get; set; }

        [DataMember]
        /// <summary>
        /// SSD - твердотельный накопитель
        /// </summary>
        public string SSD { get; set; }

        [DataMember]
        /// <summary>
        /// Видеокарта
        /// </summary>
        public string VideoAdapter { get; set; }

        [DataMember]
        /// <summary>
        /// Периферийное оборудование
        /// </summary>
        public string Peripheral { get; set; }

        [DataMember]
        /// <summary>
        /// Прочее
        /// </summary>
        public string Other { get; set; }

        [DataMember]
        /// <summary>
        /// Запись склада
        /// </summary>
        public WarehouseDataContract Warehouse { get; set; }
    }
}

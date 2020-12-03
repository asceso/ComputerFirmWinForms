using System;

namespace ApplicationModels
{
    /// <summary>
    /// Сборка компьютера
    /// </summary>
    public class ComputerModel
    {
        /// <summary>
        /// ИД Записи
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// CPU - процессор
        /// </summary>
        public string CPU { get; set; }

        /// <summary>
        /// RAM - оперативная память
        /// </summary>
        public string RAM { get; set; }

        /// <summary>
        /// HDD - жесткий диск
        /// </summary>
        public string HDD { get; set; }

        /// <summary>
        /// SSD - твердотельный накопитель
        /// </summary>
        public string SSD { get; set; }

        /// <summary>
        /// Видеокарта
        /// </summary>
        public string VideoAdapter { get; set; }

        /// <summary>
        /// Периферийное оборудование
        /// </summary>
        public string Peripheral { get; set; }

        /// <summary>
        /// Прочее
        /// </summary>
        public string Other { get; set; }

        /// <summary>
        /// Запись склада
        /// </summary>
        public WarehouseModel Warehouse { get; set; }
    }
}

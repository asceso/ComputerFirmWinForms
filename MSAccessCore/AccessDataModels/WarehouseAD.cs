using System;

namespace MSAccessCore.AccessDataModels
{
    /// <summary>
    /// Склад
    /// </summary>
    public class WarehouseAD
    {
        /// <summary>
        /// Дата поступления на склад
        /// </summary>
        public DateTime AdmissionDate { get; set; }

        /// <summary>
        /// Сотрудник принявший на склад
        /// </summary>
        public UserAD User { get; set; }

        /// <summary>
        /// Количество позиции
        /// </summary>
        public int PositionCount { get; set; }

        /// <summary>
        /// Наименование позиции
        /// </summary>
        public string PositionName { get; set; }

        /// <summary>
        /// Описание позиции
        /// </summary>
        public string PositionDescription { get; set; }
    }
}

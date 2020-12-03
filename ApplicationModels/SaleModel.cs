using System;

namespace ApplicationModels
{
    /// <summary>
    /// Модель продажи
    /// </summary>
    public class SaleModel
    {
        /// <summary>
        /// ИД
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// Номер продажи
        /// </summary>
        public string SaleNumber { get; set; }

        /// <summary>
        /// Дата и время продажи
        /// </summary>
        public DateTime SaleDate { get; set; }

        /// <summary>
        /// Ссылка на склад
        /// </summary>
        public WarehouseModel Warehouse { get; set; }

        /// <summary>
        /// Сотрудник выполнивший продажу
        /// </summary>
        public UserModel Seller { get; set; }

        /// <summary>
        /// ИД Записи из прайс листа
        /// </summary>
        public PriceListModel PriceList { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        public int PositionCount { get; set; }

        /// <summary>
        /// Закрыта или нет
        /// </summary>
        public bool IsClosed { get; set; }
    }
}

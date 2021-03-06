﻿using System;
using System.ComponentModel.DataAnnotations;

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

        [Display(Name = "Номер продажи")]
        /// <summary>
        /// Номер продажи
        /// </summary>
        public string SaleNumber { get; set; }

        /// <summary>
        /// Дата и время продажи
        /// </summary>
        [Display(Name = "Дата продажи")]
        public DateTime SaleDate { get; set; }

        /// <summary>
        /// Сотрудник выполнивший продажу
        /// </summary>
        [Display(Name = "Продавец")]
        public UserModel Seller { get; set; }

        /// <summary>
        /// ИД Записи из прайс листа
        /// </summary>
        [Display(Name = "Позиция прайс листа")]
        public PriceListModel PriceList { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        [Display(Name = "Количество")]
        public int PositionCount { get; set; }

        /// <summary>
        /// Закрыта или нет
        /// </summary>
        [Display(Name = "Заявка закрыта")]
        public bool IsClosed { get; set; }
    }
}

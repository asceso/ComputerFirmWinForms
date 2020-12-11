using System;
using System.ComponentModel.DataAnnotations;

namespace ApplicationModels
{
    /// <summary>
    /// Базовый класс заявок
    /// </summary>
    public class BaseRequestModel
    {
        /// <summary>
        /// ИД записи
        /// </summary>
        public Guid ID { get; set; }

        [Display(Name = "Дата создания заявки")]
        /// <summary>
        /// Дата создания заявки
        /// </summary>
        public DateTime OpenedDate { get; set; }

        [Display(Name = "Назначенная дата заявки")]
        /// <summary>
        /// Назначенная дата заявки
        /// </summary>
        public DateTime TargetDate { get; set; }

        [Display(Name = "Назначенный сотрудник")]
        /// <summary>
        /// Назначенный сотрудник
        /// </summary>
        public UserModel TargetUser { get; set; }

        [Display(Name = "Тип заявки")]
        /// <summary>
        /// Тип заявки
        /// </summary>
        public RequestTypeModel RequestType { get; set; }

        [Display(Name = "Клиент")]
        /// <summary>
        /// Клиент
        /// </summary>
        public ClientModel TargetClient { get; set; }

        [Display(Name = "Статус заявки")]
        /// <summary>
        /// Закрыта заявка или нет
        /// </summary>
        public string State { get; set; }
    }
}

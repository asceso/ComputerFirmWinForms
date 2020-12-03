using System;

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

        /// <summary>
        /// Дата создания заявки
        /// </summary>
        public DateTime OpenedDate { get; set; }

        /// <summary>
        /// Назначенная дата заявки
        /// </summary>
        public DateTime TargetDate { get; set; }

        /// <summary>
        /// Назначенный сотрудник
        /// </summary>
        public UserModel TargetUser { get; set; }

        /// <summary>
        /// Тип заявки
        /// </summary>
        public RequestTypeModel RequestType { get; set; }

        /// <summary>
        /// Клиент
        /// </summary>
        public ClientModel TargetClient { get; set; }

        /// <summary>
        /// Закрыта заявка или нет
        /// </summary>
        public bool IsClosed { get; set; }
    }
}

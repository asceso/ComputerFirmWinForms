using System;

namespace MSAccessCore.AccessDataModels
{
    /// <summary>
    /// Базовый класс заявок
    /// </summary>
    public class BaseRequestAD
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
        public UserAD TargetUser { get; set; }

        /// <summary>
        /// Тип заявки
        /// </summary>
        public RequestTypeAD RequestType { get; set; }

        /// <summary>
        /// Клиент
        /// </summary>
        public ClientAD TargetClient { get; set; }

        /// <summary>
        /// Закрыта заявка или нет
        /// </summary>
        public string State { get; set; }
    }
}

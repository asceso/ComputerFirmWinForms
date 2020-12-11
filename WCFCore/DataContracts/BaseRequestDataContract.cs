using System;
using System.Runtime.Serialization;

namespace WCFCore.DataContracts
{
    [DataContract]
    /// <summary>
    /// Базовый класс заявок
    /// </summary>
    public class BaseRequestDataContract
    {
        [DataMember]
        /// <summary>
        /// ИД записи
        /// </summary>
        public Guid ID { get; set; }

        [DataMember]
        /// <summary>
        /// Дата создания заявки
        /// </summary>
        public DateTime OpenedDate { get; set; }

        [DataMember]
        /// <summary>
        /// Назначенная дата заявки
        /// </summary>
        public DateTime TargetDate { get; set; }

        [DataMember]
        /// <summary>
        /// Назначенный сотрудник
        /// </summary>
        public UserDataContract TargetUser { get; set; }

        [DataMember]
        /// <summary>
        /// Тип заявки
        /// </summary>
        public RequestTypeDataContract RequestType { get; set; }

        [DataMember]
        /// <summary>
        /// Клиент
        /// </summary>
        public ClientDataContract TargetClient { get; set; }

        [DataMember]
        /// <summary>
        /// Закрыта заявка или нет
        /// </summary>
        public string State { get; set; }
    }
}

using System;
using System.Runtime.Serialization;

namespace WCFCore.DataContracts
{
    [DataContract]
    /// <summary>
    /// Клиент
    /// </summary>
    public class ClientDataContract
    {
        [DataMember]
        /// <summary>
        /// ИД записи клиента
        /// </summary>
        public Guid ID { get; set; }

        [DataMember]
        /// <summary>
        /// Имя клиента
        /// </summary>
        public string FirstName { get; set; }

        [DataMember]
        /// <summary>
        /// Фамилия клиента
        /// </summary>
        public string SecondName { get; set; }

        [DataMember]
        /// <summary>
        /// Отчество клиента
        /// </summary>
        public string LastName { get; set; }

        [DataMember]
        /// <summary>
        /// Контактный номер
        /// </summary>
        public string ContactNumber { get; set; }

        [DataMember]
        /// <summary>
        /// Холодный контакт
        /// </summary>
        public bool IsLead { get; set; }

        [DataMember]
        /// <summary>
        /// Удален в архив
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}

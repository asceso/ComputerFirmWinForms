using System;
using System.Runtime.Serialization;

namespace WCFCore.DataContracts
{
    [DataContract]
    /// <summary>
    /// Доп информация сотрудника
    /// </summary>
    public class UserInfoDataContract
    {
        [DataMember]
        /// <summary>
        /// ИД Записи
        /// </summary>
        public Guid ID { get; set; }

        [DataMember]
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }

        [DataMember]
        /// <summary>
        /// Фамилия
        /// </summary>
        public string SecondName { get; set; }

        [DataMember]
        /// <summary>
        /// Отчество
        /// </summary>
        public string LastName { get; set; }

        [DataMember]
        /// <summary>
        /// Контактный номер
        /// </summary>
        public string ContactNumber { get; set; }
    }
}

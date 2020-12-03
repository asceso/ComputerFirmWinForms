using System;
using System.Runtime.Serialization;

namespace WCFCore.DataContracts
{
    [DataContract]
    /// <summary>
    /// Сотрудники
    /// </summary>
    public class UserDataContract
    {
        [DataMember]
        /// <summary>
        /// ИД записи
        /// </summary>
        public Guid ID { get; set; }

        [DataMember]
        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; }

        [DataMember]
        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }

        [DataMember]
        /// <summary>
        /// Доп информация сотрудника
        /// </summary>
        public UserInfoDataContract UserInfo { get; set; }

        [DataMember]
        /// <summary>
        ///  Должность
        /// </summary>
        public PositionDataContract Position { get; set; }
    }
}

using System;
using System.Runtime.Serialization;

namespace WCFCore.DataContracts
{
    [DataContract]
    /// <summary>
    /// Разрешения пользователей
    /// </summary>
    public class PermissionDataContract
    {
        [DataMember]
        /// <summary> 
        /// ИД записи
        /// </summary>
        public Guid ID { get; set; }

        [DataMember]
        /// <summary>
        /// Название разрешения
        /// </summary>
        public string Name { get; set; }

        [DataMember]
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
    }
}

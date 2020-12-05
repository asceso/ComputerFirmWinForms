using System;
using System.Runtime.Serialization;

namespace WCFCore.DataContracts
{
    [DataContract]
    /// <summary>
    /// Типы заявок
    /// </summary>
    public class RequestTypeDataContract
    {
        [DataMember]
        /// <summary>
        /// ИД
        /// </summary>
        public Guid ID { get; set; }

        [DataMember]
        /// <summary>
        /// Название
        /// </summary>
        public string RequestName { get; set; }

        [DataMember]
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
    }
}

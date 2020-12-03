using System;
using System.Runtime.Serialization;

namespace WCFCore.DataContracts
{
    [DataContract]
    /// <summary>
    /// Должности
    /// </summary>
    public class PositionDataContract
    {
        [DataMember]
        /// <summary> 
        /// ИД записи
        /// </summary>
        public Guid ID { get; set; }

        [DataMember]
        /// <summary>
        /// Должность
        /// </summary>
        public string Name { get; set; }

        [DataMember]
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
    }
}

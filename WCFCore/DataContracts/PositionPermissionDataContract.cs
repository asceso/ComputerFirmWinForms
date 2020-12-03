using System;
using System.Runtime.Serialization;

namespace WCFCore.DataContracts
{
    [DataContract]
    /// <summary>
    /// Разрешения должностей
    /// </summary>
    public class PositionPermissionDataContract
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
        public PositionDataContract Position { get; set; }

        [DataMember]
        /// <summary>
        /// Разрешение
        /// </summary>
        public PermissionDataContract Permission { get; set; }
    }
}

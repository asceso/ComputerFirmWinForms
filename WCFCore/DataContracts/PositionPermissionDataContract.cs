using System;
using System.Runtime.Serialization;

namespace WCFCore.DataContracts
{
    [DataContract]
    public class PositionPermissionDataContract
    {
        [DataMember]
        public Guid ID { get; set; }

        [DataMember]
        public PositionDataContract Position { get; set; }

        [DataMember]
        public PermissionDataContract Permission { get; set; }
    }
}

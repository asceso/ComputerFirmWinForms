using System;
using System.Runtime.Serialization;

namespace WCFCore.DataContracts
{
    [DataContract]
    public class PermissionDataContract
    {
        [DataMember]
        public Guid ID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}

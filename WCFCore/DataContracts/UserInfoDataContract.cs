using System;
using System.Runtime.Serialization;

namespace WCFCore.DataContracts
{
    [DataContract]
    public class UserInfoDataContract
    {
        [DataMember]
        public Guid ID { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string SecondName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string ContactNumber { get; set; }
    }
}

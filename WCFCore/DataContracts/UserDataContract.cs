using System;
using System.Runtime.Serialization;

namespace WCFCore.DataContracts
{
    [DataContract]
    public class UserDataContract
    {
        [DataMember]
        public Guid ID { get; set; }

        [DataMember]
        public string Login { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public UserInfoDataContract UserInfo { get; set; }

        [DataMember]
        public PositionDataContract Position { get; set; }
    }
}

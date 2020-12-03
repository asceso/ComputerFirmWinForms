using System;

namespace MSAccessCore.AccessDataModels
{
    public class UserAD
    {
        public Guid ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public UserInfoAD UserInfo { get; set; }
        public PositionAD Position { get; set; }
    }
}

using System;

namespace CoreClient.ShellModels
{
    public class UserModel
    {
        public Guid ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public UserInfoModel UserInfo { get; set; }
        public PositionModel Position { get; set; }
    }
}

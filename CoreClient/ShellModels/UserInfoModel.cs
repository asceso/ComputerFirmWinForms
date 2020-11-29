using System;

namespace CoreClient.ShellModels
{
    public class UserInfoModel
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
    }
}

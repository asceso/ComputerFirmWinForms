using System;

namespace MSAccessCore.AccessDataModels
{
    public class UserInfoAD
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
    }
}

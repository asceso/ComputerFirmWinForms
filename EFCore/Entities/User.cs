using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.Entities
{
    [Table("Users")]
    public partial class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }

        [ForeignKey("UserInfo")]
        public Guid? UserInfoID { get; set; }
        public UserInfo UserInfo { get; set; }

        [ForeignKey("Position")]
        public Guid PositionID { get; set; }
        public Position Position { get; set; }
    }
}

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

        [ForeignKey("UserInfoID")]
        public UserInfo UserInfo { get; set; }
        public Guid? UserInfoID { get; set; }

        [ForeignKey("PositionID")]
        public Position Position { get; set; }
        public Guid PositionID { get; set; }
    }
}

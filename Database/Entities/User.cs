using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    [Table("User_Mst")]
    public class User : Base
    {
        public User()
        {
            Passwords = new HashSet<Password>();
        }

        [Required]
        [StringLength(50)]
        [Column(Order = 2)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        [Column(Order = 3)]
        public string Username { get; set; }
        [Required]
        [StringLength(50)]
        [Column(Order = 4)]
        public string Email { get; set; }
        [Required]
        [StringLength(20)]
        [Column(Order = 5)]
        public string UserLoginPassword { get; set; }
        [Required]
        [StringLength(50)]
        [Column(Order = 6)]
        public string Master { get; set; }
        [Required]
        [StringLength(15)]
        [Column(Order = 7)]
        public string MobileNumber { get; set; }
        [Column(Order = 8)]
        public bool IsEmailVerified { get; set; } = false;

        [Column(Order = 9)]
        public bool IsMobileNumberVerified { get; set; } = false;      

        public virtual ICollection<Password> Passwords { get; set; }
        public virtual Settings Settings { get; set; }

    }
}

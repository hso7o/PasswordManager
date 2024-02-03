using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    [Table("Password_Mst")]
    public class Password : Base
    {
        [Required]
        [StringLength(50)]
        [Column(Order = 3)]
        public string Name { get; set; }
        [StringLength(50)]
        [Column(Order = 4)]
        public string Email { get; set; }
        [StringLength(50)]
        [Column(Order = 5)]
        public string Username { get; set; }
        [Required]
        [StringLength(100)]
        [Column(Order = 6)]
        public string Website { get; set; }
        [StringLength(200)]
        [Column(Order = 7)]
        public string Text { get; set; } = string.Empty;
        [StringLength(500)]
        [Column(Order = 8)]
        public string Notes { get; set; } = string.Empty;

        [Column(Order = 2)]
        public long UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}

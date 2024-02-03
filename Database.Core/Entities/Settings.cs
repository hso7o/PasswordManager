using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Core.Entities
{
    [Table("Settings_Mst")]
    public class Settings : Base
    {
        [Column(Order = 3)]
        public string DateTimeFormat { get; set; } = string.Empty;
        [Column(Order = 4)]
        public bool ShowEmailColumn { get; set; }
        [Column(Order = 5)]
        public bool ShowUsernameColumn { get; set; }
        [Column(Order = 6)]
        public bool ShowPasswordColumn { get; set; }
        [Column(Order = 7)]
        public bool CopyPasswordColumn { get; set; } = true;

        public virtual PasswordOptions PasswordOptions { get; set; }
        [Column(Order = 2)]
        public long UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}

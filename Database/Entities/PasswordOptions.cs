using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    [Table("PasswordOptions_Dtl")]
    public class PasswordOptions : Base
    {
        [Column(Order = 3)]
        public bool AllowLowercaseCharacters { get; set; } = true;
        [Column(Order = 4)]
        public bool AllowSpecialCharacters { get; set; } = true;
        [Column(Order = 5)]
        public bool AllowUnderscoreCharacters { get; set; } = false;
        [Column(Order = 6)]
        public bool AllowSpaceCharacters { get; set; } = false;
        [Column(Order = 7)]
        public bool AllowOtherCharacters { get; set; } = false;
        [Column(Order = 8)]

        public bool RequireLowercaseCharacters { get; set; } = true;
        [Column(Order = 9)]
        public bool RequireUppercaseCharacters { get; set; } = true;
        [Column(Order = 10)]
        public bool RequireNumberCharacters { get; set; } = true;
        [Column(Order = 11)]
        public bool RequireSpecialCharacters { get; set; }= true;
        [Column(Order = 12)]
        public bool RequireUnderscoreCharacters { get; set; } = false;
        [Column(Order = 13)]
        public bool RequireSpaceCharacters { get; set; } = false;
        [Column(Order = 14)]
        public bool RequireOtherCharacters { get; set; } = false;
        [Column(Order = 15)]
        // Pick the number of characters.
        public int MinimumCharacters { get; set; } = 10;
        [Column(Order = 16)]
        public int MaximumCharacters { get; set; } = 16;

        [Column(Order = 2)]
        public long SettingsId { get; set; }
        [ForeignKey("SettingsId")]
        public virtual Settings Settings { get; set; }

    }
}

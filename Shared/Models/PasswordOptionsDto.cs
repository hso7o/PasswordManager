using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Core.Entities;

namespace Shared.Models
{
    public class PasswordOptionsDto : BaseDto<PasswordOptionsDto, PasswordOptions>
    {
        public bool AllowLowercaseCharacters { get; set; } = true;
        public bool AllowSpecialCharacters { get; set; } = true;
        public bool AllowUnderscoreCharacters { get; set; } = false;
        public bool AllowSpaceCharacters { get; set; } = false;
        public bool AllowOtherCharacters { get; set; } = false;
        public bool RequireLowercaseCharacters { get; set; } = true;
        public bool RequireUppercaseCharacters { get; set; } = true;
        public bool RequireNumberCharacters { get; set; } = true;
        public bool RequireSpecialCharacters { get; set; }= true;
        public bool RequireUnderscoreCharacters { get; set; } = false;
        public bool RequireSpaceCharacters { get; set; } = false;
        public bool RequireOtherCharacters { get; set; } = false;
        // Pick the number of characters.
        public int MinimumCharacters { get; set; } = 10;
        public int MaximumCharacters { get; set; } = 16;
        public long SettingsId { get; set; }
        public SettingsDto Settings { get; set; } = new SettingsDto();

    }
}

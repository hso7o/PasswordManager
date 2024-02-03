using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Core.Entities;

namespace Shared.Models
{
    public class SettingsDto : BaseDto<SettingsDto, Settings>
    {
        public string DateTimeFormat { get; set; } = string.Empty;
        public bool ShowEmailColumn { get; set; } = false;
        public bool ShowUsernameColumn { get; set; } = false;
        public bool ShowPasswordColumn { get; set; } = false;
        public bool CopyPasswordColumn { get; set; } = true;
        public PasswordOptionsDto PasswordOptions { get; set; } = new PasswordOptionsDto();
        public long UserId { get; set; }
        public UserDto User { get; set; } = new UserDto();
    }
}

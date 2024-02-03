using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Core.Entities;

namespace Shared.Models
{
    public class UserDto : BaseDto<UserDto, User>
    {
        public string Name { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string UserLoginPassword { get; set; } = string.Empty;
        public string Master { get; set; } = string.Empty;
        public string MobileNumber { get; set; } = string.Empty;
        public bool IsEmailVerified { get; set; } = false;
        public bool IsMobileNumberVerified { get; set; } = false;
        public List<PasswordDto> Passwords { get; set; } = new List<PasswordDto>();
        public SettingsDto Settings { get; set; } = new SettingsDto();

    }
}

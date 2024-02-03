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
    public class PasswordDto : BaseDto<PasswordDto, Password>
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Website { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public long UserId { get; set; }
        public UserDto User { get; set; } = new UserDto();
    }
}

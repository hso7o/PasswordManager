using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public static class PasswordConstants
    {
        public const string LOWERCASE_CHARACTERS = "abcdefghijklmnopqrstuvwxyz";
        public const string UPPERCASE_CHARACTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public const string NUMBER_CHARACTERS = "0123456789";
        public const string SPECIAL_CHARACTERS = @"~!@#$%^&*():;[]{}<>,.?/\|";
        public const string UNDERSCORE_CHARACTERS = "_";
        public const string SPACE_CHARACTERS = " ";
        public const string OTHER_CHARACTERS = null;
        public const int MINIMUM_CHARACTERS = 8;
        public const int MAXIMUM_CHARACTERS = 16;
    }
}

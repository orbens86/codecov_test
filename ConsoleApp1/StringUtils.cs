using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public static class StringUtils
    {
        public static string Reverse(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return new string(input.Reverse().ToArray());
        }

        public static bool IsPalindrome(string input)
        {
            var normalized = input.ToLowerInvariant().Replace(" ", "");
            return normalized == new string(normalized.Reverse().ToArray());
        }
    }
}

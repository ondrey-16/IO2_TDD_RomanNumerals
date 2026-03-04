using System;
using System.Collections;

namespace RomanNumerals
{
    public static class RomanNumerals
    {
        private static readonly Dictionary<int, String> _conversions = new Dictionary<int, String>()
        {
            {5, "V"},
            {4, "IV"},
            {1, "I"},
        };
        public static String convert(int num)
        {
            if (num <= 8)
            {
                String res = "";
                while (num > 0)
                {
                    foreach (var conv in _conversions)
                    {
                        if (num >= conv.Key)
                        {
                            res += conv.Value;
                            num -= conv.Key;
                            break;
                        }
                    }
                }
                return res;
            }
            return "";
        }
    }
}

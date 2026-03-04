using System;
using System.Collections;

namespace RomanNumerals
{
    public static class RomanNumerals
    {
        private static readonly Dictionary<int, String> _conversions = new Dictionary<int, String>()
        {
            {1000, "M"},
            {900, "CM"},
            {500, "D"},
            {400, "CD"},
            {100, "C"},
            {90, "XC"},
            {50, "L"},
            {40, "XL"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"},
        };
        public static String convert(int num)
        {
            if (num <= 3999)
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
            return "Number too large for Roman conversion";
        }
    }
}

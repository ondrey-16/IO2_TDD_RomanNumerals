using System;
using System.Collections;

namespace RomanNumerals
{
    public static class RomanNumerals
    {
        private static readonly Dictionary<int, String> _conversions = new Dictionary<int, String>()
        {
            {5, "V"},
            {1, "I"},
        };
        public static String convert(int num)
        {
            if (num <= 8)
            {
                String res = "";
                if (num >= 5)
                {
                    res += "V";
                    num -= 5;
                }
                if (num == 4)
                {
                    return "IV";
                }
                if (num >= 1 && num <= 3)
                {
                    res += new String('I', num);
                }
                return res;
            }
            return "";
        }
    }
}

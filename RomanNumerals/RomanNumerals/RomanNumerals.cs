namespace RomanNumerals
{
    public static class RomanNumerals
    {
        public static String convert(int num)
        {
            if (num == 1)
            {
                return "I";
            }
            if (num == 2)
            {
                return "II";
            }
            if (num == 3)
            {
                return "III";
            }
            return "";
        }
    }
}

namespace RomanNumerals
{
    public static class RomanNumerals
    {
        public static String convert(int num)
        {
            if (num == 4)
            {
                return "IV";
            }
            if (num >= 1 && num <= 3)
            {
                return new String('I', num);
            }
            return "";
        }
    }
}

using RomanNumerals;

namespace RomanNumeralsTests
{
    public class RomanNumeralsTests
    {
        [Theory]
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("V", 5)]
        [InlineData("VI", 6)]
        [InlineData("VII", 7)]
        [InlineData("VIII", 8)]
        [InlineData("IX", 9)]
        [InlineData("X", 10)]
        [InlineData("XXX", 30)]
        [InlineData("XL", 40)]
        [InlineData("L", 50)]
        [InlineData("LX", 60)]
        [InlineData("XC", 90)]
        [InlineData("C", 100)]
        [InlineData("CCC", 300)]
        [InlineData("CD", 400)]
        [InlineData("D", 500)]
        [InlineData("DC", 600)]
        [InlineData("CM", 900)]
        [InlineData("M", 1000)]
        [InlineData("MM", 2000)]
        public void Test_Convert_Simple_Numbers(String exp, int num)
        {
            Assert.Equal(exp, RomanNumerals.RomanNumerals.convert(num));
        }

        [Theory]
        [InlineData("CDXXIX", 429)]
        [InlineData("LXXVII", 77)]
        [InlineData("MMCCCXLIX", 2349)]
        public void Test_Convert_MoreComplicated_Numbers(String exp, int num)
        {
            Assert.Equal(exp, RomanNumerals.RomanNumerals.convert(num));
        }
        [Theory]
        [InlineData("Number too large for Roman conversion", 50000)]
        public void Test_Convert_TooLargeNumber(String exp, int num)
        {
            Assert.Equal(exp, RomanNumerals.RomanNumerals.convert(num));
        }
    }
}
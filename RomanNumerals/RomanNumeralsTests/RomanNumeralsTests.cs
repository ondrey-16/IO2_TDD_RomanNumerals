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
        public void Test_Convert_1_To_8(String exp, int num)
        {
            Assert.Equal(exp, RomanNumerals.RomanNumerals.convert(num));
        }
    }
}
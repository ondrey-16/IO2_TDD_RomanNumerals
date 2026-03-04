using RomanNumerals;

namespace RomanNumeralsTests
{
    public class RomanNumeralsTests
    {
        [Fact]
        public void Test_Convert_1_I()
        {
            Assert.Equal("I", RomanNumerals.RomanNumerals.convert(1));
        }
        [Fact]
        public void Test_Convert_2_II()
        {
            Assert.Equal("II", RomanNumerals.RomanNumerals.convert(2));
        }
    }
}
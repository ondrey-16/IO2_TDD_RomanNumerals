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
        [Fact]
        public void Test_Convert_3_III()
        {
            Assert.Equal("III", RomanNumerals.RomanNumerals.convert(3));
        }
        [Fact]
        public void Test_Convert_4_IV()
        {
            Assert.Equal("IV", RomanNumerals.RomanNumerals.convert(4));
        }
        [Fact]
        public void Test_Convert_5_V()
        {
            Assert.Equal("V", RomanNumerals.RomanNumerals.convert(5));
        }
        [Theory]
        [InlineData("VI", 6)]
        [InlineData("VII", 7)]
        [InlineData("VIII", 8)]
        public void Test_Convert_6_To_8(String exp, int num)
        {
            Assert.Equal(exp, RomanNumerals.RomanNumerals.convert(num));
        }
    }
}
using System;
using Xunit;
using System.Linq;

namespace BDSA2021.Assignment03.Tests
{
    public class DelegatesTests
    {
        Func<string, string> Reverser = (original) => String.Concat(original.Reverse());
        Func<decimal, decimal, decimal> Multiplier = (first, second) => first * second;

        Func<int, string, bool> EqualityChecker = (num, str) => {
            int asInt;
            return (int.TryParse(str, out asInt) && num == asInt);
        };

        [Fact]
        public void Reverser_ReversesSimpleWordCorrectly()
        {
            Assert.Equal("negahnepoC fo ytisrevinU TI ehT", Reverser("The IT University of Copenhagen"));
        }

        [Fact]
        public void Reverser_ReversesPalindromeCorrectly()
        {
            Assert.Equal("bob", Reverser("bob"));
        }

        [Fact]
        public void Multiplier_MultipliesPositiveByPositiveCorrectly()
        {
            Assert.Equal(14, Multiplier(3.5m, 4m));
        }

        [Fact]
        public void Multiplier_MultipliesPositiveByNegativeCorrectly()
        {
            Assert.Equal(-41, Multiplier(5m, -8.2m));
        }

        [Fact]
        public void Multiplier_MultipliesPositiveByZeroCorrectly()
        {
            Assert.Equal(0, Multiplier(300.2345m, 0m));
        }

        [Fact]
        public void Multiplier_MultipliesNegativeByZeroCorrectly()
        {
            Assert.Equal(0, Multiplier(-3.131592653589m, 0m));
        }

        [Theory()]
        [InlineData(17, "17")]
        [InlineData(0, "0")]
        [InlineData(1, "     1")]
        [InlineData(-256, "  -256")]
        [InlineData(42, "  0042")]
        public void EqualityChecker_ReturnsTrue(int number, string str)
        {
            Assert.True(EqualityChecker(number, str));
        }

        [Theory()]
        [InlineData(16, "17")]
        [InlineData(0, "    0.0001")]
        [InlineData(1, "     abc1a")]
        [InlineData(-256, " not a number")]
        [InlineData(1, "2")]
        [InlineData(-256, "256")]
        public void EqualityChecker_ReturnsFalse(int number, string str)
        {
            Assert.False(EqualityChecker(number, str));
        }
    }
}

using FluentAssertions;
using StringCalculator;
using Xunit;

namespace StringCalculatorTests
{
    public class UnitTest1
    {
        [Fact]
        public void CalculatorCanHandleEmptyStrings()
        {
            var calculator = new StringCalculatorOperator();

            calculator.Add(string.Empty).Should().Be("0");

        }

        [Theory]
        [InlineData("1", "1")]
        [InlineData("2", "2")]
        [InlineData("3", "3")]
        [InlineData("4", "4")]
        [InlineData("5", "5")]
        [InlineData("6", "6")]
        [InlineData("7000", "7000")]
        [InlineData("888", "888")]
        public void CalculatorCanHandleSingleValues(string number, string expected)
        {
            var calculator = new StringCalculatorOperator();

            calculator.Add(number).Should().Be(expected);

        }
    }
}

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

        [Theory]
        [InlineData("0,0", "0")]
        [InlineData("0,1", "1")]
        [InlineData("1,0", "1")]
        [InlineData("1,1", "2")]
        [InlineData("2,2", "4")]
        [InlineData("2,8", "10")]
        [InlineData("5,15", "20")]
        public void CalculatorCanHandleTwoValues(string numbers, string expected)
        {
            var calculator = new StringCalculatorOperator();

            calculator.Add(numbers).Should().Be(expected);
        }

        [Theory]
        [InlineData("0,0,0,0,0,0,0", "0")]
        [InlineData("0,3,7,10,5", "25")]
        [InlineData("1,2,3,4,5,6,7,8,9", "45")]
        public void CalculatorShouldHandleUnknownNumberOfArguments(string numbers, string expected)
        {
            var calculator = new StringCalculatorOperator();

            calculator.Add(numbers).Should().Be(expected);
        }

        [Theory]
        [InlineData("1.1,2.2", "3.3")]
        [InlineData("1.5,2.0,3.9", "7.4")]
        [InlineData("5.8,4.2,10.0", "20")]
        [InlineData("1.1,1.1,1.1,1.1,1.1,1.1,1.1", "7.7")]
        public void CalculatorShouldHandleDecimals(string numbers, string expected)
        {
            var calculator = new StringCalculatorOperator();

            calculator.Add(numbers).Should().Be(expected);
        }

        [Theory]
        [InlineData("1\n2,3", "6")]
        public void CalculatorShouldHandleNewLinesAsSeparators(string numbers, string expected)
        {
            var calculator = new StringCalculatorOperator();

            calculator.Add(numbers).Should().Be(expected);
        }
    }
}

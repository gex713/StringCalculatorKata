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
    }
}

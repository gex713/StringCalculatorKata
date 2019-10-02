using System;

namespace StringCalculator
{
    public class StringCalculatorOperator
    {
        public StringCalculatorOperator()
        {

        }

        public string Add(string number)
        {
            if (string.IsNullOrEmpty(number)) return "0";

            return number;            
        }
    }
}

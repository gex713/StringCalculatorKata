using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator
{
    public class StringCalculatorOperator
    {
        public StringCalculatorOperator()
        {

        }

        public string Add(string stringOfNumbers)
        {
            if (string.IsNullOrEmpty(stringOfNumbers)) return "0";

            var splitNumbers = stringOfNumbers.Split(',');
            var numbers = new List<double>();

            foreach(string num in splitNumbers)
            {
                numbers.Add(double.Parse(num));
            }

            var sum = numbers.Sum().ToString();

            return sum;            
        }
    }
}

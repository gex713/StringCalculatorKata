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

            var splitOnCommas = stringOfNumbers.Split(',');

            var splitOnNewLines = new List<string>();
            foreach(string potential in splitOnCommas)
            {
                splitOnNewLines.AddRange(potential.Split('\n').ToList());
            }

            var numbers = new List<double>();

            foreach(string num in splitOnNewLines)
            {
                numbers.Add(double.Parse(num));
            }

            var sum = numbers.Sum().ToString();

            return sum;            
        }
    }
}

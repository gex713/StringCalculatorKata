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

            var numbers = stringOfNumbers.Split(',');
            var numbersAsInts = new List<int>();

            foreach(string num in numbers)
            {
                numbersAsInts.Add(int.Parse(num));
            }

            var sum = numbersAsInts.Sum().ToString();

            return sum;            
        }
    }
}

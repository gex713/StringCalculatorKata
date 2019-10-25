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

            var positions = new List<int>();

            //Check for bad formation
            for (int i = 0; i < stringOfNumbers.Length; i++)
            {
                if (stringOfNumbers[i] == '\n' || stringOfNumbers[i] == ',')
                {
                    positions.Add(i);
                }
            }

            for (int i = 0; i < positions.Count - 1; i++)
            {
                if (positions[i] + 1 == positions[i + 1])
                {
                    if (stringOfNumbers[positions[i + 1]] == '\n')
                        return $"Number expected but \'\\n\' found at position {positions[i + 1]}.";
                    else
                        return $"Number expected but \'{(char)stringOfNumbers[positions[i + 1]]}\' found at position {positions[i + 1]}.";
                }
            }

            var splitOnCommas = stringOfNumbers.Split(',');

            var splitOnNewLines = new List<string>();
            foreach (string potential in splitOnCommas)
            {
                splitOnNewLines.AddRange(potential.Split('\n').ToList());
            }

            var numbers = new List<double>();

            foreach (string num in splitOnNewLines)
            {
                numbers.Add(double.Parse(num));
            }

            var sum = numbers.Sum().ToString();

            return sum;
        }
    }
}

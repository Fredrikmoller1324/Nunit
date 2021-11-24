using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MathOperations
    {
       public int Add(string numbers)
        {
            int sum = 0;
            if (numbers.Equals(string.Empty))
            {
                return 0;
            }
            char[] separators = new char[] { ' ', '\n' };

            string[] seperatedNumbersAsStrings = numbers.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (var number in seperatedNumbersAsStrings)
            {
                int convertedNumber;

                bool success = int.TryParse(number, out convertedNumber);
                if(convertedNumber <= 0)
                {
                    throw new ArgumentException("Input value is a number less than 0");
                }
                if (success)
                {
                    sum = sum + convertedNumber;
                }
                else
                {
                    throw new ArgumentException("Input value is not a number");
                }
            }
            
            return sum;
       }
    }
}

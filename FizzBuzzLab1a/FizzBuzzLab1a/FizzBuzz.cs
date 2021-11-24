using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzLab1a
{
    public static class FizzBuzz
    {
        /// <summary>
        ///     Calculates Fizzbuzz sequence
        /// </summary>
        /// <param name="sequenceLength"> The last number to evaluate</param>
        /// <returns> The FizzBuzz sequence </returns>
        public static List<string> CalculateFizzBuzzSequence(this int sequenceLength)
        {
            List<string> fizzBuzzSequence = new List<string>();
            for (int i = 1; i < sequenceLength + 1; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    fizzBuzzSequence.Add("FizzBuzz");
                }
                else if(i % 3 == 0)
                {
                    fizzBuzzSequence.Add("Fizz");
                }
                else if(i % 5 == 0)
                {
                    fizzBuzzSequence.Add("Buzz");
                }
                else
                {
                    fizzBuzzSequence.Add(i.ToString());
                }
            }

            return fizzBuzzSequence;
        }
    }
}

using FizzBuzzLab1a.Exceptions;
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
        /// <param name="sequenceLength"> The length of yhe fizzbuzz sequence </param>
        /// <returns> The FizzBuzz sequence </returns>
        public static List<string> CalculateFizzBuzzSequence(this int sequenceLength)
        {
            if (sequenceLength < 0) throw new NegativeNumberNotAllowedException("Negative number is not allowed");

            if (sequenceLength > 100) throw new ArgumentOutOfRangeException("Length of fizzbuzz sequence can not be longer than 100 numbers");

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

using System;

namespace FizzBuzzLab1a
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in FizzBuzz.CalculateFizzBuzzSequence(100))
            {
                Console.WriteLine(item);
            }
        }
    }
}

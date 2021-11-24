using FizzBuzzLab1a;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzTest
{
    public class Tests
    {
        [Test]
        public void CalculateFizzBuzzSequence_()
        {
            List<string> listToCheck = new List<string>() { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz","16" };

            Assert.AreEqual(listToCheck, FizzBuzz.CalculateFizzBuzzSequence(100).Take(16));
        }

    }
}
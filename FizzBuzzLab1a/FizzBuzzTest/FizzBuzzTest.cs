using FizzBuzzLab1a;
using FizzBuzzLab1a.Exceptions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzTest
{
    public class FizzBuzzTest
    {
        [Test]
        public void CalculateFizzBuzzSequence_InputIs100Numbers_Returns16FirstCases()
        {
            List<string> listToCheck = new List<string>() { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz","16" };

            Assert.AreEqual(listToCheck, FizzBuzz.CalculateFizzBuzzSequence(100).Take(16));
        }

        [Test]
        [TestCase(101)]
        [TestCase(201)]
        [TestCase(301)]
        public void CalculateFizzBuzzSequence_InputIsBiggerThan100_ThrowsArgumentOutOfRangeException(int sequenceLength)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => FizzBuzz.CalculateFizzBuzzSequence(sequenceLength));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(-10)]
        [TestCase(-100)]
        public void CalculateFizzBuzzSequence_InputIsLessThan0_ThrowsArgumentOutOfRangeException(int sequenceLength)
        {
            Assert.Throws<NegativeNumberNotAllowedException>(() => FizzBuzz.CalculateFizzBuzzSequence(sequenceLength));
        }

        [Test]
        [TestCase(2,2)]
        [TestCase(16,16)]
        [TestCase(83,83)]
        public void CalculateFizzBuzzSequence_CheckIfSequenceIsCorrectLength_ReturnsLengthOfSequence(int inputSequenceLength, int expectedSequenceLength)
        {
            int result = FizzBuzz.CalculateFizzBuzzSequence(inputSequenceLength).Count();

            Assert.That(result, Is.EqualTo(expectedSequenceLength));
        }

    }
}
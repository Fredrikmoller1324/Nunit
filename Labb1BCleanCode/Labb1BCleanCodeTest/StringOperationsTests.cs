using Labb1BCleanCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1BCleanCodeTest
{
    class StringOperationsTests
    {
        [Test]
        [TestCase("Apa", "apA")]
        [TestCase("Hello", "olleH")]
        [TestCase("nUnit", "tinUn")]
        [TestCase("best test eVer", "tseb tset reVe")]
        [TestCase("Palindromes is Hard to check", "semordnilaP si draH ot kcehc")]
        public void ReverseString_InputStringToReverse_ReturnsInputStringInReverse(string stringToReverse, string expected)
        {
            // Arrange Act
            
            string textToTest = stringToReverse.ReverseString();

            //Assert
            Assert.That(textToTest, Is.EqualTo(expected));
        }
    }
}

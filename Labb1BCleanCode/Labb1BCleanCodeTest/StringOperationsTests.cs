using Labb1BCleanCode;
using Moq;
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
        private Mock<IFileOperations> _mock;
        
        [SetUp]
        public void SetUp()
        {
            _mock = new Mock<IFileOperations>();
        }

        [Test]
        [TestCase("Apa", "apA")]
        [TestCase("Hello", "olleH")]
        [TestCase("nUnit", "tinUn")]
        [TestCase("best test eVer", "tseb tset reVe")]
        [TestCase("Palindromes is Hard to check", "semordnilaP si draH ot kcehc")]
        public void ReverseString_InputStringToReverse_ReturnsInputStringInReverse(string stringToReverse, string expected)
        {
            // Arrange Act
            _mock.Setup(x=>x.Read()).Returns(stringToReverse);

            //Assert
            Assert.That(new StringOperations().ReverseString(_mock.Object), Is.EqualTo(expected));
        }
    }
}

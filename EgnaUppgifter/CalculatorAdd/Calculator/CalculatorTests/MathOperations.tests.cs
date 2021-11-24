using Calculator;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTests
{
    [TestFixture]
    class MathoperationsTest
    {
       [Test]
        public void Add_GivenInputIsEmpty_Returns0()
        {
            //Arrange
            MathOperations mathOp = new MathOperations();
            string InputValue = string.Empty;
            int expectedValue = 0;

            //Act
            int calcResult = mathOp.Add(InputValue);
            
            //Assert
            Assert.That(calcResult, Is.EqualTo(expectedValue));
        }

        [Test]
        [TestCase("2",2)]
        [TestCase("2 3", 5)]
        [TestCase("2 3 4", 9)]
        [TestCase("2\n8 4",14)]
        public void Add_GivenInputIsNumbersAsNumbers_ReturnsSumOfNumbers(string inputAsString, int expectedSum)
        {
            //Arrange
            MathOperations mathOp = new MathOperations();
            

            //Act
            int calcResult = mathOp.Add(inputAsString);

            //Assert
            Assert.That(calcResult, Is.EqualTo(expectedSum));
        }

        [Test]
        public void Add_GivenInputIsNotaNumber_ThrowsArgumentException()
        {
            //Arrange
            MathOperations mathOp = new MathOperations();
            string InputValue = "1 2 abc";

            //Act & Assert
            Assert.Throws<ArgumentException>(() => mathOp.Add(InputValue));
        }

        [Test]
        public void Add_GivenInputIsNegativeNumber_ThrowsArgumentException()
        {
            //Arrange
            MathOperations mathOp = new MathOperations();
            string InputValue = "-1";

            //Act & Assert
            Assert.Throws<ArgumentException>(() => mathOp.Add(InputValue));
        }
    }
}

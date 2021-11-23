using Labb1BCleanCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1BCleanCodeTest
{
    [TestFixture]
    class StringOperationsTest
    {
        [Test]
        public void GetFilePath_PathDoNotExist_ThrowsException()
        {

        }

        [Test]
        public void ReadFromTxtFile_FileIsEmptyOrNull_ThrowsArgumentException()
        {
            // Arrange
            StringOperations textReaderObj = new StringOperations();
            var filepath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "empty_mock_data.txt");

            //Act
            ArgumentException ex = Assert.Throws<ArgumentException>(() => textReaderObj.ReadFromTxtFile(filepath));

            //Assert
            Assert.AreEqual("File is Null or Empty", ex.Message);

        }

        [Test]
        public void ReadFromTxtFile_StringIsOneLine_ReturnsTrue()
        {
            // Arrange
            StringOperations textReaderObj = new StringOperations();
            string filepath = textReaderObj.GetFilePath();
            //Act
            string textToTest = textReaderObj.ReadFromTxtFile(filepath);

            bool result = !textToTest.Contains(Environment.NewLine);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase("Apa","apA")]
        [TestCase("Hello","olleH")]
        [TestCase("nUnit","tinUn")]
        [TestCase("best test eVer","tseb tset reVe")]
        [TestCase("Palindromes is Hard to check","semordnilaP si draH ot kcehc")]
        public void ReverseString_InputStringToReverse_ReturnsInputStringInReverse(string stringToReverse, string expected)
        {
            // Arrange
            StringOperations textReaderObj = new StringOperations();

            //Act
            string textToTest = textReaderObj.ReverseString(stringToReverse);

            //Assert
            Assert.That(textToTest, Is.EqualTo(expected));
        }


    }
}

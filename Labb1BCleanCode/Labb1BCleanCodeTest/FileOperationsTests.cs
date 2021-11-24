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
    class FileOperationsTests
    {
        [Test]
        public void ReadFromTxtFile_FileIsEmptyOrNull_ThrowsArgumentException()
        {
            // Arrange
            FileOperations textReaderObj = new FileOperations();

            string path = textReaderObj.GetFilePath("empty_mock_data.txt");

            //Act
            ArgumentException ex = Assert.Throws<ArgumentException>(() => textReaderObj.ReadFromFile(path));

            //Assert
            Assert.AreEqual("File is Null or Empty", ex.Message);

        }

        [Test]
        public void GetFilePath_GivenFileNotExist_ThrowFileNotFoundException()
        {
            FileOperations textReaderObj = new FileOperations();
            string testFileName = "Error";

            Assert.Throws<FileNotFoundException>(() => textReaderObj.GetFilePath(testFileName));
        } 
        [Test]
        public void GetFilePath_GivenFileIsNotOfTypeTxt_ThrowFileArgumentException()
        {
            FileOperations textReaderObj = new FileOperations();

            Assert.Throws<FileNotFoundException>(() => textReaderObj.GetFilePath("testOtherFileType"));
        }

        [Test]
        public void ReadFromTxtFile_StringIsOneLine_ReturnsTrue()
        {
            // Arrange
            FileOperations textReaderObj = new FileOperations();
            string filepath = textReaderObj.GetFilePath("indata.txt");
            
            //Act
            string textToTest = textReaderObj.ReadFromFile(filepath);

            bool result = !textToTest.Contains(Environment.NewLine);

            //Assert
            Assert.That(result, Is.True);
        }
    }
}

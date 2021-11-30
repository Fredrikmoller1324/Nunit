using Labb1BCleanCode;
using Moq;
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
    class TextFileOperationsTests
    {
        IFileOperations _fileOperations;
        [SetUp]
        public void SetUp()
        {
          _fileOperations = new TextFileOperations();
        }

        [Test]
        public void ReadFromTxtFile_FileIsEmptyOrNull_ThrowsArgumentException()
        {
            // Arrange
            var path = _fileOperations.GetFilepath("empty_mock_data.txt"); 
     
            //Act
            ArgumentException ex = Assert.Throws<ArgumentException>(() => _fileOperations.Read(path));

            //Assert
            Assert.AreEqual("File is Null or Empty", ex.Message);
        }

        [Test]
        public void GetFilePath_GivenFileNotExist_ThrowFileNotFoundException()
        {
            string testfilename = "error";

            Assert.Throws<FileNotFoundException>(() => _fileOperations.GetFilepath(testfilename));
        }
        [Test]
        public void GetFilepath_GivenFileIsNotOfTypetxt_ThrowFileArgumentException()
        {
            Assert.Throws<FileNotFoundException>(() => _fileOperations.GetFilepath("testotherfiletype"));
        }

        [Test]
        public void ReadFromtxtFile_StringReturnedIsOneline_ReturnsTrue()
        {
            // arrange

            string filepath = _fileOperations.GetFilepath("indata.txt");

            //act
            string texttotest = _fileOperations.Read(filepath);

            bool result = !texttotest.Contains(Environment.NewLine);

            //assert
            Assert.That(result, Is.True);
        }
    }
}

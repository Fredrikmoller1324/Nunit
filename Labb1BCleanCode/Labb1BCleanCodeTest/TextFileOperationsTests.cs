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
        private TextFileOperations _txtFileOperations;
        private Mock<IFileOperations> _mock;
        [SetUp]
        public void SetUp()
        {
            _txtFileOperations = new TextFileOperations();
            _mock = new Mock<IFileOperations>();
        }

        [Test]
        public void ReadFromTxtFile_FileIsEmptyOrNull_ThrowsArgumentException()
        {
            // Arrange
            _mock.Setup(x => x.Read()).Throws(new ArgumentException());

            _txtFileOperations.GetFilepath("empty_mock_data.txt");

            //Act
            ArgumentException ex = Assert.Throws<ArgumentException>(() => _txtFileOperations.Read());

            //Assert
            Assert.AreEqual("File is Null or Empty", ex.Message);
        }

        [Test]
        public void GetFilePath_GivenFileNotExist_ThrowFileNotFoundException()
        {
            _mock.Setup(x => x.GetFilepath("error")).Throws(new FileNotFoundException());

            Assert.Throws<FileNotFoundException>(() => _txtFileOperations.GetFilepath("error"));
        }
        [Test]
        public void GetFilepath_GivenFileIsNotOfTypetxt_ThrowFileArgumentException()
        {
            Assert.Throws<FileNotFoundException>(() => _txtFileOperations.GetFilepath("testotherfiletype"));
        }

        [Test]
        public void ReadFromtxtFile_StringReturnedIsOneline_ReturnsTrue()
        {
            // arrange
            _txtFileOperations.GetFilepath("indata.txt");
            string texttotest = _txtFileOperations.Read();

            //act
            bool result = !texttotest.Contains(Environment.NewLine);

            //assert
            Assert.That(result, Is.True);
        }
    }
}

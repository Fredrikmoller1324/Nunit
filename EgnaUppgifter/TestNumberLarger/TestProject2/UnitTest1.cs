using NUnit.Framework;
using TestNumberLarger;

namespace TestProject2
{
    public class Tests
    {
        [Test]
        public void NumberIsLargerThanTen_InputTwenty_IsTrue()
        {
            int numberToTest = 20;

            var result = numberToTest.NumberIsLargerThanTen();

            Assert.That(result, Is.True);
        }
    }
}
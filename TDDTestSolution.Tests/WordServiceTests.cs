using NUnit.Framework;
using TDDTestSolution.Services;

namespace TDDTestSolution.Tests
{
    public class WordServiceTests
    {
        [Test]
        public void WordWrap_CorrectData_WrappedString()
        {
            // Arrange
            var characterCount = 4;
            var service = new WordWrapService(characterCount);
            var value = "this is a test";
            var expectedResult = "this\n is a t\nest";

            // Act
            var result = service.WordWrap(value);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void WordWrap_EmptyData_EmptyString()
        {
            // Arrange
            var characterCount = 5;
            var service = new WordWrapService(characterCount);
            string value = null;
            var expectedResult = string.Empty;

            // Act
            var result = service.WordWrap(value);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void WordWrap_InputeTextShorterThenCharacterCount_NoWrappedString()
        {
            // Arrange
            var characterCount = 10;
            var service = new WordWrapService(characterCount);
            string value = "test value";
            var expectedResult = "test value";

            // Act
            var result = service.WordWrap(value);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void WordWrap_InputeTextWithNewLineAfterNewLine_WrappedStringWithoutAdditionalNewLineAfterNewLine()
        {
            // Arrange
            var characterCount = 5;
            var service = new WordWrapService(characterCount);
            string value = "The quick brown fox jumps over\nthe lazy dog";
            var expectedResult = "The qu\nick br\nown fo\nx jump\ns over\nthe la\nzy dog\n";

            // Act
            var result = service.WordWrap(value);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}

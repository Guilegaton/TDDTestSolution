using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TDDTestSolution.Services;

namespace TDDTestSolution.Tests
{
    public class OddEvenServiceTests
    {
        [Test]
        public void CheckNumber_OddNumber_ReturnsOddText()
        {
            // Arrange
            var service = new OddEvenService();
            var value = 5;
            var expectedValue = "Odd";

            // Act
            var result = service.CheckNumber(value);

            // Assert
            Assert.AreEqual(expectedValue, result);
        }

        [Test]
        public void CheckNumber_EvenNumber_ReturnsEvenText()
        {
            // Arrange
            var service = new OddEvenService();
            var value = 10;
            var expectedValue = "Even";

            // Act
            var result = service.CheckNumber(value);

            // Assert
            Assert.AreEqual(expectedValue, result);
        }

        [Test]
        public void CheckNumber_PrimeNumber_ReturnsPrimeText()
        {
            // Arrange
            var service = new OddEvenService();
            var value = 10;
            var expectedValue = "Prime";

            // Act
            var result = service.CheckNumber(value);

            // Assert
            Assert.AreEqual(expectedValue, result);
        }

        [Test]
        public void CheckNumber_CorrectData_ReturnsRangeOfCheckedNumberText()
        {
            // Arrange
            var service = new OddEvenService();
            var value = 10;
            var expectedValue = "1 - Prime\r\n2 - Prime\r\n3 - Prime\r\n4 - Even\r\n5 - Prime\r\n6 - Even\r\n7 - Prime\r\n8 - Even\r\n9 - Odd\r\n10 - Even";

            // Act
            var result = service.CheckRange(value);

            // Assert
            Assert.AreEqual(expectedValue, result);
        }

    }
}

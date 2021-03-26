using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TDDTestSolution.Services;

namespace TDDTestSolution.Tests
{
    public class LCDDigitsServiceTests
    {
        [Test]
        public void Convert_Correct()
        {
            // Arrange
            var service = new LCDDigitsService();
            uint value = 15;
            var expectedValue =
@"... ._.
..| | _.
..| ._ |";

            // Act
            var result = service.Convert(value);

            // Assert
            Assert.AreEqual(expectedValue, result);
        }
    }
}

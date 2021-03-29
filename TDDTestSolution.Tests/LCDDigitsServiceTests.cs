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
            uint value = 1234567890;
            var expectedValue = "... ._. ._. ... ._. ._. ._. ._. ._. ._. \r\n..| ._| ._| |_| |_. |_. ..| |_| |_| |.| \r\n..| |_. ._| ..| ._| |_| ..| |_| ..| |_| \r\n";

            // Act
            var result = service.Convert(value);

            // Assert
            Assert.IsTrue(expectedValue == result);
        }
    }
}

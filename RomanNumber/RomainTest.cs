using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RomanNumber
{
    public class RomainTest
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(10, "X")]
        [InlineData(7, "VII")]
        [InlineData(354, "CCCLIV")]
        [InlineData(3000, "MMM")]
        public void RomanConversion_WithValidInput_ShouldReturnExpectedValue(int number, string expected)
        {
            // Arrange

            // Act
            string result = Roman.RomanConversion(number);

            // Assert
            Assert.Equal(expected, result);
        }

    }
}

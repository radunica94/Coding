using Calculator.Business;
using Xunit;

namespace Calculator.Tests
{
    public class DivisionMethodTest
    {
        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(4, 2, 2)]
        [InlineData(8, 2, 4)]
        [InlineData(16, 2, 8)]
        [InlineData(14.996, 2, 7.498)]
        [InlineData(3, 2, 1.5)]
        [InlineData(1,10, 0.1)]
        public void DivisionMethod_ShouldReturnCorrectResult(double x, double y, double expected)
        {
            // Arrange
            DivisionMethod division = new DivisionMethod();

            // Act
            double actual = division.Division(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(2, 0, 0)]
        [InlineData(0, 2, 0)]
        public void DivisionMethod_ShouldReturnCorrectResult_WhenDivisionByZero(double x, double y,double expected)
        {
            // Arrange
            DivisionMethod division = new DivisionMethod();

            // Act
            double actual = division.Division(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(2, 2, 0)]
        [InlineData(4, 2, 0)]
        [InlineData(8, 2, 0)]
        [InlineData(16, 2, 0)]
        [InlineData(14.996, 2, 10)]
        [InlineData(3, 2, 0)]
        [InlineData(2, 3, 0)]
        public void DivisionMethod_ShouldNotReturnCorectResult(double x, double y, double expected)
        {
            // Arrange
            DivisionMethod division = new DivisionMethod();

            // Act
            double actual = division.Division(x, y);

            // Assert
            Assert.NotEqual(expected, actual);
        }
    }
}

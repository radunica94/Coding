using Calculator.Business;
using Xunit;

namespace Calculator.Tests
{
    public class SqrtMethodTest
    {
        [Theory]
        [InlineData(81, 9)]
        [InlineData(36, 6)]
        [InlineData(25, 5)]
        [InlineData(100, 10)]
        [InlineData(0, 0)]
        public void SqrtMethod_ShouldReturnCorrectResult(double number,double expected)
        {
            // Arrange
            SqrtMethod sqrt = new SqrtMethod();

            // Act
            double actual = sqrt.Sqrt(number);

            // Assert
            Assert.Equal(expected,actual);
        }
        [Theory]
        [InlineData(81, 8)]
        [InlineData(36, 7)]
        [InlineData(25, 6)]
        [InlineData(100, 11)]
        [InlineData(0, 1)]
        public void SqrtMethod_ShouldNotReturnCorrectResult(double number, double expected)
        {
            // Arrange
            SqrtMethod sqrt = new SqrtMethod();

            // Act
            double actual = sqrt.Sqrt(number);

            // Assert
            Assert.NotEqual(expected, actual);
        }        
    }
}

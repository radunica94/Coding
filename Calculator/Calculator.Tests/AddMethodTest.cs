using Calculator.Business;
using Xunit;

namespace Calculator.Tests
{
    public class AddMethodTest
    {
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(10, 10, 20)]
        [InlineData(35, 35, 70)]
        [InlineData(30, -50, -20)]
        [InlineData(3.6579, 12.6892, 16.3471)]
        public void AddMethod_ShouldReturnCorrectResult(double x, double y, double expected)
        {
            // Arrange
            AddMethod add = new AddMethod();

            // Act
            double actual = add.Add(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(1, 1, 3)]
        [InlineData(2, 2, 10)]
        [InlineData(10, 10, 100)]
        [InlineData(35, 35, 105)]
        [InlineData(30, -50, -10)]
        [InlineData(3.6579, 12.6892, 15.3471)]
        public void AddMethod_ShouldNotReturnCorrectResult(double x, double y, double expected)
        {
            // Arrange
            AddMethod add = new AddMethod();

            // Act
            double actual = add.Add(x, y);

            // Assert
            Assert.NotEqual(expected, actual);
        }
    }
}

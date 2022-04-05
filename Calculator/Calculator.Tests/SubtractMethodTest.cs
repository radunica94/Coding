using Calculator.Business;
using Xunit;

namespace Calculator.Tests
{
    public class SubtractMethodTest
    {
        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(10, 5, 5)]
        [InlineData(0, 0, 0)]
        [InlineData(-10, 9, -19)]
        [InlineData(20.996, -9, 29.996)]
        public void SubtractMethod_ShouldReturnCorrectResult(double x, double y, double expected)
        {
            SubtractMethod subtract = new SubtractMethod();

            double actual = subtract.Subtract(x, y);

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(2, 1, 0)]
        [InlineData(10, 5, 0)]
        [InlineData(12, 4, 9)]
        [InlineData(0, 0, 1)]
        [InlineData(-10, 9, -1)]
        [InlineData(20.996, -9, 21.996)]
        public void SubtractMethod_ShouldNotReturnCorrectResult(double x, double y, double expected)
        {
            SubtractMethod subtract = new SubtractMethod();

            double actual = subtract.Subtract(x, y);

            Assert.NotEqual(expected, actual);
        }
    }
}

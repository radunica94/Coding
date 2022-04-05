using Calculator.Business;
using Xunit;

namespace Calculator.Tests
{
    public class MultiplyMethodTest
    {
        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(2, 3, 6)]
        [InlineData(2, 4, 8)]
        [InlineData(2, 5, 10)]
        [InlineData(16.3471, 0.336, 5.492625600000001)]
        [InlineData(30, -25, -750)]
        public void MultiplyMethod_ShouldReturnCorrectResult(double x, double y, double exception)
        {
            MultiplyMethod multiply = new MultiplyMethod();

            double actual = multiply.Multiply(x, y);

            Assert.Equal(exception, actual);
        }
        [Theory]
        [InlineData(2, 2, 5)]
        [InlineData(2, 3, 7)]
        [InlineData(2, 4, 9)]
        [InlineData(2, 5, 11)]
        [InlineData(16.3471, 0.336, 5.4926256)]
        [InlineData(30, -25, 750)]
        public void MultiplyMethod_ShouldNotReturnCorrectResult(double x, double y, double exception)
        {
            MultiplyMethod multiply = new MultiplyMethod();

            double actual = multiply.Multiply(x, y);

            Assert.NotEqual(exception, actual);
        }
    }
}

using Calculator.Business;
using Xunit;

namespace Calculator.Tests
{
    public class PowMethodTest
    {
        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(2, 3, 8)]
        [InlineData(2, 4, 16)]
        [InlineData(2, 5, 32)]
        [InlineData(2, 6, 64)]
        [InlineData(7, 2, 49)]
        [InlineData(7, 3, 343)]
        [InlineData(3, 3, 27)]
        public void PowMethod_ShouldReturnCorrectResult(double x, double y , double expected)
        {
            PowMethod pow = new PowMethod();
            
            double actual = pow.Pow(x, y);

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(-2,2,4)]
        [InlineData(-2, 3, -8)]
        [InlineData(-2, 4, 16)]
        [InlineData(-2, 5, -32)]
        [InlineData(2,-2,0.25)]
        [InlineData(2, -3, 0.125)]
        [InlineData(2, -4, 0.0625)]
        public void PowMethod_ShouldReturnCorrectResult_ForNegativeNumbers(double x, double y, double expected)
        {
            PowMethod pow = new PowMethod();

            double actual = pow.Pow(x, y);

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(2, 2, 45)]
        [InlineData(2, 3, 8.1)]
        [InlineData(2, 4, 16.1)]
        [InlineData(2, 5, 32.1)]
        public void PowMethod_ShouldNotReturnCorrectResult(double x, double y,double expected)
        {
            PowMethod pow = new PowMethod();

            double actual = pow.Pow(x, y);

            Assert.NotEqual(expected, actual);
        }
    }
}

using Calculator.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculator.Tests
{
    public class Pow2MethodTest
    {
        [Theory]
        [InlineData(2,4)]
        [InlineData(3,9)]
        public void Pow2Method_ShouldReturnTrueValues(double x,  double expected)
        {
            PowMethod pow = new PowMethod();

            double actual = pow.Pow2(x);
            Assert.Equal(expected, actual);
        }
    }
}

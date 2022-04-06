using Calculator.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculator.Tests
{
    public class Pow3MethodTest
    {
        [Theory]
        [InlineData(2,8)]
        [InlineData(3, 27)]
        [InlineData(4, 64)]
        [InlineData(5, 125)]
        public void Pow3Method_ShouldReturnTrueValue(double value,double expected)
        {
            PowMethod pow = new PowMethod();
            
            double actual = pow.Pow3(value);

            Assert.Equal(expected, actual);
        }
    }
}

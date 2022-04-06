using Calculator.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculator.Tests
{
    public class SinMethodTest
    {
        [Theory]
        [InlineData(90, 0.8939966636005579)]
        public void SinMethod_ShouldReturnCorrectValue(double value,double expected)
        {
            SinMethod sin = new SinMethod();
            double actual = sin.Sin(value);
            Assert.Equal(expected, actual);
        }
    }
}

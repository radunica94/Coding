using Calculator.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculator.Tests
{
    public class FactorialMethodTest
    {
        [Theory]
        [InlineData(2,2)]
        [InlineData(4,24)]
        [InlineData(6,720)]
        [InlineData(8, 40320)]
        [InlineData(10, 3628800)]
        
        public void FactorialTest_ShouldReturnCorrectResult(double value, double expected)
        {
            FactorialMethod fact = new FactorialMethod();

            double actual = fact.Factorial(value);

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(3,5)]
        [InlineData(5, 121)]
        [InlineData(7, 5041)]
        public void FactorialTest_ShouldNotReturnCorrectResult(double value, double expected)
        {
            FactorialMethod fact = new FactorialMethod();

            double actual = fact.Factorial(value);

            Assert.NotEqual(expected, actual);
        }
    }
}

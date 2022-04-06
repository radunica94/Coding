using Calculator.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculator.Tests
{
    public class BitwiseOperatorsMethodTest
    {
        [Theory]
        [InlineData(14,11,10)]
        [InlineData(60,13,12)]
        public void AndMethod_ShouldReturnPossitiveValue(int x , int y, int expected)
        {
            BitwiseOperatorsMethod bit = new BitwiseOperatorsMethod();

            int actual = bit.AND(x, y);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(60, 13, 61)]
        public void OrMethod_ShouldReturnPossitiveValue(int x, int y, int expected)
        {
            BitwiseOperatorsMethod bit = new BitwiseOperatorsMethod();

            int actual = bit.OR(x, y);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(60, 13, 49)]
        public void XorMethod_ShouldReturnPossitiveValue(int x, int y, int expected)
        {
            BitwiseOperatorsMethod bit = new BitwiseOperatorsMethod();

            int actual = bit.XOR(x, y);

            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(60, -61)]
        public void NotMethod_ShouldReturnPossitiveValue(int x, int expected)
        {
            BitwiseOperatorsMethod bit = new BitwiseOperatorsMethod();

            int actual = bit.NOT(x);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(60, 2, 240)]
        public void LeftShiftMethod_ShouldReturnPossitiveValue(int x, int y, int expected)
        {
            BitwiseOperatorsMethod bit = new BitwiseOperatorsMethod();

            int actual = bit.LeftShift(x, y);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(60, 2, 15)]
        public void RightShiftMethod_ShouldReturnPossitiveValue(int x, int y, int expected)
        {
            BitwiseOperatorsMethod bit = new BitwiseOperatorsMethod();

            int actual = bit.RightShift(x, y);

            Assert.Equal(expected, actual);
        }
    }
}

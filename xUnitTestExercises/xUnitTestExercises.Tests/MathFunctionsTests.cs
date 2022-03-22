using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using xUnitTestExercises.Library;

namespace xUnitTestExercises.Tests
{
    public class MathFunctionsTests
    {
        //Sqrt Function
        [Fact]
        public void SqrtMethodTested_ShouldPassTheFirstTest()
        {
            MathFunction math = new MathFunction();
            double expected = 9;
            double actual = math.SqrtMethod(81);
            Assert.Equal(expected, actual); 
        }
        [Fact]
        public void SqrtMethodTested_ShouldPassTheSecondTest()
        {
            MathFunction math = new MathFunction();
            double expected = 22;
            double actual = math.SqrtMethod(484);
            Assert.Equal(expected, actual); 
        }
        [Fact]
        public void SqrtMethodTested_ShouldNotPassTheFirstTest()
        {
            MathFunction math = new MathFunction();
            double expected = 10;
            double actual = math.SqrtMethod(81);
            Assert.Equal(expected, actual);
        }
        //Pow Function
        [Fact]
        public void PowMethodTested_ShouldPassTheFirstTest()
        {
            MathFunction math = new MathFunction();
            double expected = 4;
            double actual = math.PowMethod(2, 2);
            Assert.Equal(expected, actual); 
        }
        [Fact]
        public void PowMethodTested_ShouldPassTheSecondTest()
        {
            MathFunction math = new MathFunction();
            double expected = 81;
            double actual = math.PowMethod(9, 2);
            Assert.Equal(expected, actual); 
        }
        [Fact]
        public void PowMethodTested_ShouldNotPassTheFirstTest()
        {
            MathFunction math = new MathFunction();
            double expected = 82;
            double actual = math.PowMethod(10, 2);
            Assert.Equal(expected,actual);
        }        
    }
}

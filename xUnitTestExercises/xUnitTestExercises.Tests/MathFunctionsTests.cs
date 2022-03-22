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
            MathFunctions math = new MathFunctions();
            double expected = 9;
            double actual = math.SqrtMethod(81);
            Assert.Equal(expected, actual); 
        }
        [Fact]
        public void SqrtMethodTested_ShouldPassTheSecondTest()
        {
            MathFunctions math = new MathFunctions();
            double expected = 22;
            double actual = math.SqrtMethod(484);
            Assert.Equal(expected, actual); 
        }
        [Fact]
        public void SqrtMethodTested_ShouldNotPassTheFirstTest()
        {
            MathFunctions math = new MathFunctions();
            double expected = 10;
            double actual = math.SqrtMethod(81);
            Assert.Equal(expected, actual);
        }
        //Pow Function
        [Fact]
        public void PowMethodTested_ShouldPassTheFirstTest()
        {
            MathFunctions math = new MathFunctions();
            double expected = 4;
            double actual = math.PowMethod(2, 2);
            Assert.Equal(expected, actual); 
        }
        [Fact]
        public void PowMethodTested_ShouldPassTheSecondTest()
        {
            MathFunctions math = new MathFunctions();
            double expected = 81;
            double actual = math.PowMethod(9, 2);
            Assert.Equal(expected, actual); 
        }
        [Fact]
        public void PowMethodTested_ShouldNotPassTheFirstTest()
        {
            MathFunctions math = new MathFunctions();
            double expected = 82;
            double actual = math.PowMethod(10, 2);
            Assert.Equal(expected,actual);
        }
        //Abs(Decimal) Functions
        [Fact]
        public void AbsDecimalMethodTested_ShouldPassTheFirstTest()
        {
            MathFunctions math = new MathFunctions();
            decimal expected = 45.55M;
            decimal actual = math.AbsDecimalMethod(-45.55M);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsDecimalMethodTested_ShouldPassTheSecondTest()
        {
            MathFunctions math = new MathFunctions();
            decimal expected = 58.2M;
            decimal actual = math.AbsDecimalMethod(-58.2M);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsDecimalMethodTested_ShouldPassTheThirdTest()
        {
            MathFunctions math = new MathFunctions();
            decimal expected = 0.0M;
            decimal actual = math.AbsDecimalMethod(0.0M);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsDecimalMethodTested_ShouldNotPassTheFirstTest()
        {
            MathFunctions math = new MathFunctions();
            decimal expected = 0.01M;
            decimal actual = math.AbsDecimalMethod(0.0M);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsDecimalMethodTested_ShouldNotPassTheSecondTest()
        {
            MathFunctions math = new MathFunctions();
            decimal expected = 33;
            decimal actual = math.AbsDecimalMethod(33.2M);
            Assert.Equal(expected, actual);
        }
        // Abs(Double) Function
        [Fact]
        public void AbsDoubleMethodTested_ShouldPassTheFirstValue()
        {
            MathFunctions math = new MathFunctions();
            double expected = 45.55;
            double actual = math.AbsDoubleMethod(-45.55);
            Assert.Equal(expected, actual); 
        }
        [Fact]
        public void AbsDoubleMethodTested_ShouldPassTheSecondValue()
        {
            MathFunctions math = new MathFunctions();
            double expected = 5.555E-09;
            double actual = math.AbsDoubleMethod(-55.55e-10);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsDoubleMethodTested_ShouldPassTheThirdTest()
        {
            MathFunctions math = new MathFunctions();
            double expected = 0;
            double actual = math.AbsDoubleMethod(0.0);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsDoubleMethodTested_ShouldNotPassTheFirstTest()
        {
            MathFunctions math = new MathFunctions();
            double expected = 0.01;
            double actual = math.AbsDoubleMethod(0.0);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsDoubleMethodTested_ShouldNotPassTheSecondTest()
        {
            MathFunctions math = new MathFunctions();
            double expected = 33;
            double actual = math.AbsDoubleMethod(33.2);
            Assert.Equal(expected, actual);
        }
        // Abs(Int16) Function
        [Fact]
        public void AbsInt16MethodTested_ShouldPassFirstTest()
        {
            MathFunctions math = new MathFunctions();
            Int16 expected = 45;
            Int16 actual = math.AbsInt16Method(-45);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsInt16MethodTested_ShouldPassSecondTest()
        {
            MathFunctions math = new MathFunctions();
            Int16 expected = 58;
            Int16 actual = math.AbsInt16Method(-58);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsInt16MethodTested_ShouldPassThirdTest()
        {
            MathFunctions math = new MathFunctions();
            Int16 expected = 7;
            Int16 actual = math.AbsInt16Method(7);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsInt16MethodTested_ShouldNotPassFirstTest()
        {
            MathFunctions math = new MathFunctions();
            Int16 expected = -45;
            Int16 actual = math.AbsInt16Method(45);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsInt16MethodTested_ShouldNotPassSecondTest()
        {
            MathFunctions math = new MathFunctions();
            Int16 expected = 11;
            Int16 actual = math.AbsInt16Method(-10);
            Assert.Equal(expected, actual);
        }
        // Abs(Int32) Function
        [Fact]
        public void AbsInt32MethodTested_ShouldPassFirstTest()
        {
            MathFunctions math = new MathFunctions();
            Int32 expected = 455844525;
            Int32 actual = math.AbsInt32Method(-455844525);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsInt32MethodTested_ShouldPassSecondTest()
        {
            MathFunctions math = new MathFunctions();
            Int32 expected = 7;
            Int32 actual = math.AbsInt32Method(7);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsInt32MethodTested_ShouldNotPassFirstTest()
        {
            MathFunctions math = new MathFunctions();
            Int32 expected = -58;
            Int32 actual = math.AbsInt32Method(58);
            Assert.Equal(expected, actual);
        }
        // Abs(Int64) Function
        [Fact]
        public void AbsInt64MethodTested_ShouldPassFirstTest()
        {
            MathFunctions math = new MathFunctions();
            Int64 expected = 9455844525;
            Int64 actual = math.AbsInt64Method(-9455844525);
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void AbsInt64MethodTested_ShouldPassSecondTest()
        {
            MathFunctions math = new MathFunctions();
            Int64 expected = 7;
            Int64 actual = math.AbsInt64Method(7);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsInt64MethodTested_ShouldNotPassSecondTest()
        {
            MathFunctions math = new MathFunctions();
            Int64 expected = -58;
            Int64 actual = math.AbsInt64Method(-58);
            Assert.Equal(expected, actual);
        }
        // Abs(SByte) Function
        [Fact]
        public void AbsSByteMethodTested_ShouldPassFirstTest()
        {
            MathFunctions math = new MathFunctions();
            SByte expected = 87;
            SByte actual = math.AbsSByteMethod(-87);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsSByteMethodTested_ShouldPassSecondTest()
        {
            MathFunctions math = new MathFunctions();
            SByte expected = 7;
            SByte actual = math.AbsSByteMethod(7);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsSByteMethodTested_ShouldNotPassFirstTest()
        {
            MathFunctions math = new MathFunctions();
            SByte expected = -87;
            SByte actual = math.AbsSByteMethod(87);
            Assert.Equal(expected, actual);
        }
        // Abs(Single) Function
        [Fact]
        public void AbsSingleMethodTested_ShouldPassFirstTest()
        {
            MathFunctions math = new MathFunctions();
            Single expected = 87;
            Single actual = math.AbsSingleMethod(-87);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsSingleMethodTested_ShouldPassSecondTest()
        {
            MathFunctions math = new MathFunctions();
            Single expected = 87;
            Single actual = math.AbsSingleMethod(87);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsSingleMethodTested_ShouldNotPassFirstTest()
        {
            MathFunctions math = new MathFunctions();
            Single expected = -87;
            Single actual = math.AbsSingleMethod(87);
            Assert.Equal(expected, actual);
        }
    }
}

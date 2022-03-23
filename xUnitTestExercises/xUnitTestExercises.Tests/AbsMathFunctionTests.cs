using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using xUnitTestExercises.Library;

namespace xUnitTestExercises.Tests
{
    public class AbsMathFunctionTests
    {
        //Abs(Decimal) Functions
        [Fact]
        public void AbsDecimalMethodTested_ShouldPassTheFirstTest()
        {
            AbsMathFunction math = new AbsMathFunction();
            decimal expected = 45.55M;
            decimal actual = math.AbsDecimalMethod(-45.55M);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsDecimalMethodTested_ShouldPassTheSecondTest()
        {
            AbsMathFunction math = new AbsMathFunction();
            decimal expected = 58.2M;
            decimal actual = math.AbsDecimalMethod(-58.2M);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsDecimalMethodTested_ShouldPassTheThirdTest()
        {
            AbsMathFunction math = new AbsMathFunction();
            decimal expected = 0.0M;
            decimal actual = math.AbsDecimalMethod(0.0M);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsDecimalMethodTested_ShouldNotPassTheFirstTest()
        {
            AbsMathFunction math = new AbsMathFunction();
            decimal expected = 0.01M;
            decimal actual = math.AbsDecimalMethod(0.0M);
            Assert.NotEqual(expected, actual);
        }
        [Fact]
        public void AbsDecimalMethodTested_ShouldNotPassTheSecondTest()
        {
            AbsMathFunction math = new AbsMathFunction();
            decimal expected = 33;
            decimal actual = math.AbsDecimalMethod(33.2M);
            Assert.NotEqual(expected, actual);
        }
        // Abs(Double) Function
        [Fact]
        public void AbsDoubleMethodTested_ShouldPassTheFirstValue()
        {
            AbsMathFunction math = new AbsMathFunction();
            double expected = 45.55;
            double actual = math.AbsDoubleMethod(-45.55);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsDoubleMethodTested_ShouldPassTheSecondValue()
        {
            AbsMathFunction math = new AbsMathFunction();
            double expected = 5.555E-09;
            double actual = math.AbsDoubleMethod(-55.55e-10);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsDoubleMethodTested_ShouldPassTheThirdTest()
        {
            AbsMathFunction math = new AbsMathFunction();
            double expected = 0;
            double actual = math.AbsDoubleMethod(0.0);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsDoubleMethodTested_ShouldNotPassTheFirstTest()
        {
            AbsMathFunction math = new AbsMathFunction();
            double expected = 0.01;
            double actual = math.AbsDoubleMethod(0.0);
            Assert.NotEqual(expected, actual);
        }
        [Fact]
        public void AbsDoubleMethodTested_ShouldNotPassTheSecondTest()
        {
            AbsMathFunction math = new AbsMathFunction();
            double expected = 33;
            double actual = math.AbsDoubleMethod(33.2);
            Assert.NotEqual(expected, actual);
        }
        // Abs(Int16) Function
        [Fact]
        public void AbsInt16MethodTested_ShouldPassFirstTest()
        {
            AbsMathFunction math = new AbsMathFunction();
            Int16 expected = 45;
            Int16 actual = math.AbsInt16Method(-45);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsInt16MethodTested_ShouldPassSecondTest()
        {
            AbsMathFunction math = new AbsMathFunction();
            Int16 expected = 58;
            Int16 actual = math.AbsInt16Method(-58);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsInt16MethodTested_ShouldPassThirdTest()
        {
            AbsMathFunction math = new AbsMathFunction();
            Int16 expected = 7;
            Int16 actual = math.AbsInt16Method(7);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsInt16MethodTested_ShouldNotPassFirstTest()
        {
            AbsMathFunction math = new AbsMathFunction();
            Int16 expected = -45;
            Int16 actual = math.AbsInt16Method(45);
            Assert.NotEqual(expected, actual);
        }
        [Fact]
        public void AbsInt16MethodTested_ShouldNotPassSecondTest()
        {
            AbsMathFunction math = new AbsMathFunction();
            Int16 expected = 11;
            Int16 actual = math.AbsInt16Method(-10);
            Assert.NotEqual(expected, actual);
        }
        // Abs(Int32) Function
        [Fact]
        public void AbsInt32MethodTested_ShouldPassFirstTest()
        {
            AbsMathFunction math = new AbsMathFunction();
            Int32 expected = 455844525;
            Int32 actual = math.AbsInt32Method(-455844525);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsInt32MethodTested_ShouldPassSecondTest()
        {
            AbsMathFunction math = new AbsMathFunction();
            Int32 expected = 7;
            Int32 actual = math.AbsInt32Method(7);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsInt32MethodTested_ShouldNotPassFirstTest()
        {
            AbsMathFunction math = new AbsMathFunction();
            Int32 expected = -58;
            Int32 actual = math.AbsInt32Method(58);
            Assert.NotEqual(expected, actual);
        }
        // Abs(Int64) Function
        [Fact]
        public void AbsInt64MethodTested_ShouldPassFirstTest()
        {
            AbsMathFunction math = new AbsMathFunction();
            Int64 expected = 9455844525;
            Int64 actual = math.AbsInt64Method(-9455844525);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsInt64MethodTested_ShouldPassSecondTest()
        {
            AbsMathFunction math = new AbsMathFunction();
            Int64 expected = 7;
            Int64 actual = math.AbsInt64Method(7);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsInt64MethodTested_ShouldNotPassSecondTest()
        {
            AbsMathFunction math = new AbsMathFunction();
            Int64 expected = -58;
            Int64 actual = math.AbsInt64Method(-58);
            Assert.NotEqual(expected, actual);
        }
        // Abs(SByte) Function
        [Fact]
        public void AbsSByteMethodTested_ShouldPassFirstTest()
        {
            AbsMathFunction math = new AbsMathFunction();
            SByte expected = 87;
            SByte actual = math.AbsSByteMethod(-87);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsSByteMethodTested_ShouldPassSecondTest()
        {
            AbsMathFunction math = new AbsMathFunction();
            SByte expected = 7;
            SByte actual = math.AbsSByteMethod(7);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsSByteMethodTested_ShouldNotPassFirstTest()
        {
            AbsMathFunction math = new AbsMathFunction();
            SByte expected = -87;
            SByte actual = math.AbsSByteMethod(87);
            Assert.NotEqual(expected, actual);
        }
        // Abs(Single) Function
        [Fact]
        public void AbsSingleMethodTested_ShouldPassFirstTest()
        {
            AbsMathFunction math = new AbsMathFunction();
            Single expected = 87;
            Single actual = math.AbsSingleMethod(-87);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsSingleMethodTested_ShouldPassSecondTest()
        {
            AbsMathFunction math = new AbsMathFunction();
            Single expected = 87;
            Single actual = math.AbsSingleMethod(87);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AbsSingleMethodTested_ShouldNotPassFirstTest()
        {
            AbsMathFunction math = new AbsMathFunction();
            Single expected = -87;
            Single actual = math.AbsSingleMethod(87);
            Assert.NotEqual(expected, actual);
        }
    }
}

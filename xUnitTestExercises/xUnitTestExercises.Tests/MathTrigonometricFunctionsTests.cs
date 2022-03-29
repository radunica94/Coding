using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using xUnitTestExercises.Library;

namespace xUnitTestExercises.Tests
{
    public class MathTrigonometricFunctionsTests
    {
        // Acos
        [Fact]
        public void AcosMethod_ShouldPassFirstTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = double.NaN;
            double actual = math.AcosMethod(Math.PI);
            Assert.Equal(expected, actual); 
        }
        [Fact]
        public void AcosMethod_ShouldPassSecondTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = double.NaN;
            double actual = math.AcosMethod(2);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AcosMethod_ShouldPassThiredTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = 1.204242852965772;
            double actual = math.AcosMethod(0.3584);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AcosMethod_ShouldNotPassFirstTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = 90;
            double actual = math.AcosMethod(0.0);
            Assert.NotEqual(expected, actual);
        }

        // Acosh
        [Fact]
        public void AcoshMethod_ShouldPassFirstTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = 1.5667992369724109;
            double actual = math.AcoshMethod(2.5f);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AcoshMethod_ShouldPassSecondTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = 0;
            double actual = math.AcoshMethod(1);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AcoshMethod_ShouldNotPassFirstTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = 0;
            double actual = math.AcoshMethod(0);
            Assert.NotEqual(expected, actual);
        }

        // Asin
        [Fact]
        public void AsinMethod_ShouldPassFirstTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = double.NaN;
            double actual = math.AsinMethod(Math.PI);
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void AsinMmethod_ShouldPassSecondTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = 0.3665534738291246;
            double actual = math.AsinMethod(0.3584);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AsinMethod_ShouldNotPassFirstTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = 1;
            double actual = math.AsinMethod(2);
            Assert.NotEqual(expected, actual);
        }

        // Asinh
        [Fact]
        public void AsinhMethod_ShouldPassFirstTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = -2.312438341272753;
            double actual = math.AsinhMethod(-5);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AsinhMethod_ShouldPassSecondTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = 0.881373587019543;
            double actual = math.AsinhMethod(1);
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void AsinhMethod_ShouldNotPassFirstTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = 0;
            double actual = math.AsinhMethod(1);
            Assert.NotEqual(expected , actual);
        }

        // Atan
        [Fact]
        public void AtanMethod_ShouldPassFirstTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = 0.7853981633974483;
            double actual = math.AtanMethod(1);
            Assert.Equal (expected, actual);
        }
        [Fact]
        public void AtanMethod_ShouldPassSecondTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = 0;
            double actual = math.AtanMethod(0);
            Assert.Equal(expected , actual);
        }
        [Fact]
        public void AtanMethod_ShouldNotPassFirstTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = 0;
            double actual = math.AtanMethod(1); 
            Assert.NotEqual(expected, actual);
        }

        // Atan2
        [Theory]
        [InlineData(0,0,0)]
        [InlineData(2,2, 0.7853981633974483)]
        [InlineData(2,-2, 2.356194490192345)]
        [InlineData(-2,-2, -2.356194490192345)]
        [InlineData(-2,2, -0.7853981633974483)]
        public void Atan2Method_ShouldPassTests(double x, double y, double expected)
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double actual = math.Atan2Method(x, y);
            Assert.Equal(expected,actual);
        }
        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(2, 2, 0.785398163397448)]
        [InlineData(2, -2, 2.35619449019234)]
        [InlineData(-2, -2, -2.35619449019234)]
        [InlineData(-2, 2, -0.785398163397448)]
        public void Atan2Method_ShouldNotPassTests(double x, double y, double expected)
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double actual = math.Atan2Method(x, y);
            Assert.NotEqual(expected, actual);
        }

        // Atanh
    }
}

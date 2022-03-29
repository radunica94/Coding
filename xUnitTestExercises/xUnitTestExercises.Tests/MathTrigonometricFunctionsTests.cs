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
        [Fact]
        public void AtanhMethod_ShouldPassFirstTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = 0;
            double actual = math.AtanhMethod(0);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AtanhMethod_ShouldPassSecondTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = double.PositiveInfinity;
            double actual = math.AtanhMethod(1);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AtanhMethod_ShouldNotPassFirstTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = double.NegativeInfinity;
            double actual = math.AtanhMethod(1);
            Assert.NotEqual(expected, actual);
        }

        // Cos
        [Fact]
        public void CosMethod_ShouldPassFirstTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = 1;
            double actual = math.CosMethod(0);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CosMethod_ShouldPassSecondTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = double.NaN;
            double actual = math.CosMethod(double.NegativeInfinity);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CosMethod_ShouldNotPassFirstTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = double.NaN;
            double actual = math.CosMethod(0);
            Assert.NotEqual(expected , actual);
        }

        // Cosh
        [Fact]
        public void CoshMethod_ShouldPassFirstTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = 1;
            double actual = math.CoshMethod(0);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CoshMethod_ShouldPassSecondTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = double.PositiveInfinity;
            double actual = math.CoshMethod(double.NegativeInfinity);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CoshMethod_ShouldPassThiredTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = double.PositiveInfinity;
            double actual = math.CoshMethod(double.PositiveInfinity);
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void CoshMethod_ShouldNotPasFirstTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = double.NegativeInfinity;
            double actual = math.CoshMethod(double.PositiveInfinity);
            Assert.NotEqual(expected, actual);
        }

        // Sin
        [Fact]
        public void SinMethod_ShouldPassFirstTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = 0.7071067811865476;
            double actual = math.SinMethod(Math.PI/4); //45 grade
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SinMethod_ShouldPassSecondTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = -0.5478534738880397;
            double actual = math.SinhMethod(-Math.PI/6);//-60 grade
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SinMethod_ShouldNotPassFirstTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = 0;
            double actual = math.SinhMethod(Math.PI/2);//90 grade
            Assert.NotEqual(expected, actual);
        }

        // Sinh
        [Fact]
        public void SinhMethod_ShouldPassFirstTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = 0;
            double actual = math.SinhMethod(0);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SinhMethod_ShouldPassSecondTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = double.PositiveInfinity;
            double actual = math.SinhMethod(double.PositiveInfinity);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SinhMethod_ShouldNotPassFirstTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = double.NegativeInfinity;
            double actual = math.SinhMethod(double.PositiveInfinity);
            Assert.NotEqual(expected, actual);
        }

        // Tan
        [Fact]
        public void TanMethod_ShouldPassFirstTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = 0.9999999999999999;//1
            double actual = math.TanMethod(Math.PI / 4);//45 grade
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TanMethod_ShouldPassSecondTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = 0;
            double actual = math.TanMethod(0);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TanMethod_ShouldNotPassFirstTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = 0;
            double actual = math.TanMethod(1);
            Assert.NotEqual(expected, actual);
        }

        // Tanh 
        [Fact]
        public void TanhMethod_ShouldPassFirstTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = 0;
            double actual = math.TanhMethod(0);
            Assert.Equal(expected,actual);  
        }
        [Fact]
        public void TanhMethod_ShouldPassSecondTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = 1;
            double actual = math.TanhMethod(double.PositiveInfinity);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TanhMethod_ShouldNotPassFirstTest()
        {
            MathTrigonometricFunctions math = new MathTrigonometricFunctions();
            double expected = 1;
            double actual = math.TanhMethod(double.NegativeInfinity);
            Assert.NotEqual(expected, actual);
        }
    }
}

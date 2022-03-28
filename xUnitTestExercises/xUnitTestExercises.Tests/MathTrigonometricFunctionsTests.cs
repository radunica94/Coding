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
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using xUnitTestExercises.Library;

namespace xUnitTestExercises.Tests
{
    public class MathAlgebraFunctionsTests
    {
        //Sqrt Function
        [Fact]
        public void SqrtMethodTested_ShouldPassTheFirstTest()
        {
            MathAlgebraFunctions math = new MathAlgebraFunctions();
            double expected = 9;
            double actual = math.SqrtMethod(81);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SqrtMethodTested_ShouldPassTheSecondTest()
        {
            MathAlgebraFunctions math = new MathAlgebraFunctions();
            double expected = 22;
            double actual = math.SqrtMethod(484);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SqrtMethodTested_ShouldNotPassTheFirstTest()
        {
            MathAlgebraFunctions math = new MathAlgebraFunctions();
            double expected = 10;
            double actual = math.SqrtMethod(81);
            Assert.NotEqual(expected, actual);
        }
        //Pow Function
        [Fact]
        public void PowMethodTested_ShouldPassTheFirstTest()
        {
            MathAlgebraFunctions math = new MathAlgebraFunctions();
            double expected = 4;
            double actual = math.PowMethod(2, 2);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void PowMethodTested_ShouldPassTheSecondTest()
        {
            MathAlgebraFunctions math = new MathAlgebraFunctions();
            double expected = 81;
            double actual = math.PowMethod(9, 2);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void PowMethodTested_ShouldNotPassTheFirstTest()
        {
            MathAlgebraFunctions math = new MathAlgebraFunctions();
            double expected = 82;
            double actual = math.PowMethod(10, 2);
            Assert.NotEqual(expected, actual);
        }
    }
}

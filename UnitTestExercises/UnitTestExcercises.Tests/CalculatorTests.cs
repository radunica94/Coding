using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExercises;
using Xunit;

namespace UnitTestExercises.Tests
{
    public class CalculatorTests
    {
        [Fact]
        //Name convention: Method name '_' what the test shoud do
        public void Add_SimpleValuesShoudlCalculate()
        {
            Calculator calc = new Calculator();
            // Arrange
            double expected = 5;

            // Act
            double actual = calc.Add(3, 2);

            // Assert
            Assert.Equal(expected, actual);
            //23:00
        }
        [Fact]
        public void Subtract_SimpleValuesShouldCalculate()
        {
            Calculator calc = new Calculator();
            double expected = 10;
            double actual = calc.Subtract(40, 30);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Multiply_SimpleValuesShouldCalculate()
        {
            Calculator calc = new Calculator();
            double expected = 25;
            double actual = calc.Multiply(5, 5);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Divide_SimpleValuesShouldCalculate()
        {
            Calculator calc = new Calculator();
            double expected = 9;
            double actual = calc.Divide(81, 9);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void DivideWithRest_SimpleValuesShoudlCalculate()
        {
            Calculator calc = new Calculator();
            double expected = 7.5;
            double actual = calc.Divide(15, 2);
            Assert.Equal(expected, actual);
        }
    }
}
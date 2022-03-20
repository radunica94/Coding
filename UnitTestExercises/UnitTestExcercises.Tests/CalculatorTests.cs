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
        [Theory]
        [InlineData(4,3,7)]
        [InlineData(21,5.25,26.25)]
        [InlineData(double.MaxValue,5,double.MaxValue)]
        [InlineData(5,-5,0)]
        public void AddTheory_SimpleValuesShouldCalculate(double x , double y, double expected)
        {
            Calculator calc = new Calculator();
            double actual = calc.Add(x, y);
            Assert.Equal(expected, actual); 
        }

        [Theory]
        [InlineData(8, 4, 2)]
        public void DivideTheory_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            Calculator calc = new Calculator();
            double actual = calc.Divide(x, y);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_DivideByZero()
        {
            Calculator calc = new Calculator();
            double expected = 0;
            double actual = calc.Divide(15,0);
            Assert.Equal(expected, actual);
        }
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
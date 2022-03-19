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
            // Arrange
            double expected = 5;

            // Act
            double actual = Calculator.Add(3, 2);

            // Assert
            Assert.Equal(expected, actual); 
            //23:00
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using xUnitTestExercises.Library;

namespace xUnitTestExercises.Tests
{
    public class GoatsTests
    {
        [Fact]
        public void CalculateKilogrammsOfHay_ShouldPass()
        {
            Goats goats = new Goats();
            double expected = 2.857142857142857;
            double actual = goats.CalculateKilogrammsOfHay(7, 10, 50, 4, 1);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CalculateKilogrammsOfHay_ShouldPassithLowValues()
        {
            Goats goats = new Goats();
            double expected = 6;
            double actual = goats.CalculateKilogrammsOfHay(1, 1, 3, 2, 1);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CalculateKilogrammsOfHay_ShouldPassithBiggerValues()
        {
            Goats goats = new Goats();
            double expected = 100000.00000000001;
            double actual = goats.CalculateKilogrammsOfHay(30, 20, 1000, 200, 300);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CalculateKilogrammsOfHay_ShouldNotPassWithLowValues()
        {
            Goats goats = new Goats();
            double expected = 7;
            double actual = goats.CalculateKilogrammsOfHay(1, 1, 3, 2, 1);
            Assert.Equal(expected, actual);
        }

    }
}

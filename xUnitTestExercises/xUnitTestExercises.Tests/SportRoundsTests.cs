using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using xUnitTestExercises.Library;

namespace xUnitTestExercises.Tests
{
    public class SportRoundsTests
    {
        [Fact]
        public void TotalRounds_ShouldPassWithEightTeams()
        {
            SportRounds totalRounds = new SportRounds();
            int expected = 4;
            int actual = totalRounds.CalculateNumberOfRounds(8);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TotalRounds_ShouldPassWithSixteenTeams()
        {
            SportRounds totalRounds = new SportRounds();
            int expected = 8;
            int actual = totalRounds.CalculateNumberOfRounds(16);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TotalRounds_ShouldNotPassWithSixteenTeams()
        {
            SportRounds totalRounds = new SportRounds();
            int expected = 9;
            int actual = totalRounds.CalculateNumberOfRounds(16);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TotalRounds_ShouldNotPassWithSeventeenTeams()
        {
            SportRounds totalRounds = new SportRounds();
            int expected = 7;
            int actual = totalRounds.CalculateNumberOfRounds(17);
            Assert.Equal(expected, actual);
        }
    }
}

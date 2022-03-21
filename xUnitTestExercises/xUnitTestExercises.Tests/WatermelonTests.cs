using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using xUnitTestExercises.Library;

namespace xUnitTestExercises.Tests
{
    public class WatermelonTests
    {
        [Fact]
        public void CheckWatermelonWeight_TrueValues()
        {    
            Watermelon watermalon = new Watermelon();
            bool expectation = true;
            bool actual = watermalon.CheckWatermelonKg(20);
            Assert.Equal(expectation, actual);  
        }
        [Fact]
        public void CheckWatermelonWeight_FalseValues()
        {
            Watermelon watermalon = new Watermelon();
            bool expectation = false;
            bool actual = watermalon.CheckWatermelonKg(21);
            Assert.Equal(expectation, actual);
        }
    }
}

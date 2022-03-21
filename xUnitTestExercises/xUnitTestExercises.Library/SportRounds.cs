using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTestExercises.Library
{
    public class SportRounds
    {
        public int CalculateNumberOfRounds(int teams)
        {
            int totalEliminationRounds = teams/2;
            return totalEliminationRounds;
        }
    }
}

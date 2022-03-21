using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTestExercises.Library
{
    public class Goats
    {
        public double CalculateKilogrammsOfHay(int noOfDays, int noOfGoats, double kgOfHay, int days, int goats)
        {
            double hayPerGoatPerDay = kgOfHay / (noOfDays * noOfGoats);
            double consumedHay = hayPerGoatPerDay * days * goats;
            return consumedHay;
        }
    }
}

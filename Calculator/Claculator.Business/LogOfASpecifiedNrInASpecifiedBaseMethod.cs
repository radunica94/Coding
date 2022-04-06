using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Business
{
    public class LogOfASpecifiedNrInASpecifiedBaseMethod
    {
        // logaritmul unui număr specificat într-o bază specificată.
        public double Log(double number, double newBase)
        {
            double result = Math.Log(number, newBase);

            return result;
        }
    }
}

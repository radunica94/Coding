using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Business
{
    public class PowMethod
    {
        public double Pow(double x, double y)
        {
            double result = Math.Pow(x, y);
            return result;
        }
        public double Pow2(double x)
        {
            double y = 2;
            double result = Math.Pow(x, y);
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Business
{
    public class Logarithm
    {
        public double LogNat(double a)
        {
            double result = Math.Log(a);
            return result;
        }
        public double Log2(double x)
        {
            double result = Math.Log2(x);
            return result;            
        }

        public double Log10(double x)
        {
            double result = Math.Log10(x);
            return result;
        }

        public double Log(double x, double newBase)
        {
            double result = Math.Log(x, newBase);
            return result;
        }
        // TODO - test
    }
}

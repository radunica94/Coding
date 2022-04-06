using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Business
{
    public class FactorialMethod
    {
        public double Factorial(double value)
        {
            double fact = 1;
            for (int i = 1; i <= value; i++)
            {
                fact = fact * i;
            }
            return fact;
        }        
    }
}

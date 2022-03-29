using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTestExercises.Library
{
    public class MathAlgebraFunctions
    {
        // Sqrt - Returnează rădăcina pătrată a unui număr specificat.
        public double SqrtMethod(double input)
        {
            return Math.Sqrt(input);
        }
        // Pow - Returns a specified number raised to the specified power. 
        public double PowMethod(double nrToBeRaised, double nrThatSpecifiesThePower)
        {
            return Math.Pow(nrToBeRaised, nrThatSpecifiesThePower);
        }

        // Cbrt(double)

        // Log(double)

        // Log(double,double)

        //Log10(double)

        // Log2(double)

        // ILogB(double)
    }
}

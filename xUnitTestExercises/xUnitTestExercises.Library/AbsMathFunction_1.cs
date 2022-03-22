using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTestExercises.Library
{
    public class MathFunction
    {
        // Sqrt Function
        public double SqrtMethod(double input)
        {            
            return Math.Sqrt(input);
        }
        // Pow Function 
        public double PowMethod(double nrToBeRaised, double nrThatSpecifiesThePower)
        {
            return Math.Pow(nrToBeRaised,nrThatSpecifiesThePower);
        }        
    }
}

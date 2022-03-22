using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTestExercises.Library
{
    public class MathFunctions
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
        // Abs(Decimal) Functions
        public decimal AbsDecimalMethod(decimal value)
        {
            return Math.Abs(value);
        }
        // Abs(Double) Function
        public double AbsDoubleMethod(double value)
        {
            return Math.Abs(value);
        }
        // Abs(Int16) Function
        public Int16 AbsInt16Method(Int16 value)
        {
            return Math.Abs(value);
        } 
        // Abs(Int32) Function
        public Int32 AbsInt32Method()
        {
            return 0;
        }
        // Abs(Int64) Function
        public Int64 AbsInt64Method()
        {
            return 0;
        }
        // Abs(SByte) Function
        public SByte AbsSByteMethod()
        {
            return 0;
        }
        // Abs(Single) Function
        public Single AbsSingleMethod()
        {
            return 0;
        }
    }
}

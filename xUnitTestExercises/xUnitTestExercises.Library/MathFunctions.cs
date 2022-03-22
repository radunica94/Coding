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
        public Int32 AbsInt32Method(Int32 value)
        {
            return Math.Abs(value);
        }
        // Abs(Int64) Function
        public Int64 AbsInt64Method(Int64 value)
        {
            return Math.Abs(value);
        }
        // Abs(SByte) Function
        public SByte AbsSByteMethod(SByte value)
        {
            return Math.Abs(value);
        }
        // Abs(Single) Function
        public Single AbsSingleMethod(Single value)
        {
            return Math.Abs(value);
        }
    }
}

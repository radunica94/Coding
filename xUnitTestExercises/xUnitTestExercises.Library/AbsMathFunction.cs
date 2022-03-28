using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTestExercises.Library
{
    public class AbsMathFunction
    {
        // Abs(Decimal) - Returnează valoarea absolută a unui număr zecimal.
        public decimal AbsDecimalMethod(decimal value)
        {
            return Math.Abs(value);
        }
        // Abs(Double) - Returnează valoarea absolută a unui număr în virgulă mobilă cu precizie dublă.
        public double AbsDoubleMethod(double value)
        {
            return Math.Abs(value);
        }
        // Abs(Int16) - Returnează valoarea absolută a unui număr întreg cu semn de 16 biți.
        public Int16 AbsInt16Method(Int16 value)
        {
            return Math.Abs(value);
        }
        // Abs(Int32) - Returnează valoarea absolută a unui număr întreg cu semn de 32 de biți.
        public Int32 AbsInt32Method(Int32 value)
        {
            return Math.Abs(value);
        }
        // Abs(Int64) - Returnează valoarea absolută a unui număr întreg cu semn pe 64 de biți.
        public Int64 AbsInt64Method(Int64 value)
        {
            return Math.Abs(value);
        }
        // Abs(SByte) - Returnează valoarea absolută a unui număr întreg cu semn de 8 biți.
        public SByte AbsSByteMethod(SByte value)
        {
            return Math.Abs(value);
        }
        // Abs(Single) - Returnează valoarea absolută a unui număr în virgulă mobilă cu precizie unică.
        public Single AbsSingleMethod(Single value)
        {
            return Math.Abs(value);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Business
{
    public class BitwiseOperatorsMethod
    {
        public int AND(int x, int y)
        {
            int result = x & y;
            
            return result;
        }

        public int OR(int x, int y)
        {
            int result = x | y;

            return result;
        }

        public int XOR(int x, int y)
        {
            int result = x ^ y;

            return result;
        }

        public int NOT(int x)
        {
            int result = ~x;

            return result;
        }

        public int LeftShift(int x, int y)
        {
            int result = x << y;

            return result;
        }

        public int RightShift(int x, int y)
        {
            int result = x >> y;

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTestExercises.Library
{
    public class Watermelon
    {
        public Boolean CheckWatermelonKg(int watermelonWeight)
        {
            if(watermelonWeight % 2 == 0)
            {
                return true;
            }   
            else if(watermelonWeight % 2 == 1)
            {
                return false;
            }
            return false;   
        }
    }
}

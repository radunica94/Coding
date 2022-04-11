using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegasireaInformatiei
{
    public class Articol
    {
        private int repetitions;
        public Articol(int index, int count)
        {
            Index = index;
            repetitions = count;
        }

        public int Index { get; }
        public int Repetitions 
        { 
            get
            {
                return repetitions;
            }
        }

        public void Count(int repetitions)
        {
            repetitions++;
        }
    }
}

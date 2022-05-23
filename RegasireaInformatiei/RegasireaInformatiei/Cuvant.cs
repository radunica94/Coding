using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegasireaInformatiei
{
    public class Cuvant
    {
        public Cuvant(int index, double count)
        {
            Index = index;
            Repetitions = count;
        }

        public int Index { get; }
        public double Repetitions { get; set; }
    }

    public class Euclidian
    {
        public Euclidian(string name, double sum)
        {
            Name = name;
            Sum = sum;
        }

        public string Name { get; }
        public double Sum { get; }
    }
}

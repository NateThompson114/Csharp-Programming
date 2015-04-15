using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Class_Library
{
    public class Calc
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Sutract(double x, double y)
        {
            return x - y;
        }
    }

    namespace Arithmetic
    {
        public class AddingMachine
        {
            public double Add(params double[] x)
            {
                double sum = 0;
                foreach (var d in x)
                {
                    sum += d;
                }
                return sum;
            }
        }
    }
}

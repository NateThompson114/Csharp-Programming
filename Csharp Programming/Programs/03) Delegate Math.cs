using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Programming.Programs
{
    public delegate void DoTheMath(int x, int y);
    public class _03__Delegate_Math
    {
        public static event DoTheMath ops;

        public static void Add(int x, int y)
        {
            Console.WriteLine("ADD: The sum of {0} + {1} is {2}",x,y,x+y);
        }

        public static void Subtract(int x, int y)
        {
            Console.WriteLine("SUBTRACT: The difference of {0} - {1} is {2}",x,y, x-y);
        }

        public void DoMath(int x, int y)
        {
            ops = new DoTheMath(Add);
            ops += new DoTheMath(Subtract); // without the +=, ops will be overwritten and only Subtract will be run.
            ops(x, y);
        }
    }
}

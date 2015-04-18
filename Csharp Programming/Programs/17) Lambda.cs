using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Programming.Programs
{
    public class _17__Lambda
    {
        private static int myvar = 5;

        public Func<int> Adder()
        {
            return () => ++myvar;
        }

        public Func<int, int> Square()
        {
            return (int a) => (a*a);
        }

        public int Get()
        {
            return myvar;
        }

        public Func<dynamic, dynamic, int, dynamic> Divide = (a, b, round) => Math.Round(a/b, round);
        public Func<dynamic, dynamic, int, dynamic> Multiply = (a, b, round) => Math.Round(a*b, round);
        
    }
}

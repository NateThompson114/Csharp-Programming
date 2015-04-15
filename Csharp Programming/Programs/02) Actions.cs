using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Programming.Programs
{
    public class _02__Actions
    {
        private static void showCube(dynamic i)
        {
            Console.WriteLine("The cube of {0} is {1}",i,i*i*i);
        }

        public void ActionCenter(double input)
        {
            var cubeIt = new Action<dynamic>(showCube);

            dynamic x = input;
            cubeIt(x);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Programming.Programs
{
    public class _05__Square : _05__Rectangle
    {
        public void mySquare(double sideOne)
        {
            _05__Square mySquare = new _05__Square();
            double sqrarea = mySquare.Area(sideOne, sideOne);
            Console.WriteLine("This area is {0}", sqrarea);
        }
    }
}

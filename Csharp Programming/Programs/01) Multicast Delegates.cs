using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Programming.Programs
{
    internal delegate void D(int x);
    public class _01__Multicast_Delegates
    {
        public void Square(int i)
        {
            Console.WriteLine("{0} squared is {1}.", i, i*i);
        }

        public void Cube(int i)
        {
            Console.WriteLine("{0} cubed is {1}", i, i*i*i);
        }

        public void MulticastDelegates(int i)
        {
            var newProg = new _01__Multicast_Delegates();
            D del1, del2, del3;
            del1 = newProg.Square;
            del2 = newProg.Cube;
            del3 = del1 + del2;
            del3(i);

            
        }
    }
}

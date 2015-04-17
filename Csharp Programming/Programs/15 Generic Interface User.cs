using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Programming.Programs
{
    class _15_Generic_Interface_User<T> : _15__Generic_Interface<T>
    {
        public void Show()
        {
            Console.WriteLine("This code runs from the generic class.");            
        }
    }
}

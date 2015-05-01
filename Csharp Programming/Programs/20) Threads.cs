using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp_Programming.Programs
{
    public class _20__Threads
    {
        public void Worker()
        {
            for (var i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
                if (i == 5)
                {
                    Console.WriteLine(Thread.GetDomain());
                    Thread.Sleep(5000);
                }
            }
        }
    }
}

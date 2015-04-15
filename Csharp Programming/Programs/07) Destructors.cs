using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Csharp_Programming.Programs
{
    public class _07__Destructors
    {
        static Stopwatch timer;
        public class sample
        {
            
            public sample()
            {
                timer = Stopwatch.StartNew();
                Console.WriteLine("This code runs when the object is constructed.");
            }

            public void HowLong()
            {
                Console.WriteLine("{0} has lived for {1}.",this, timer.Elapsed);
                Console.ReadLine();
            }

            ~sample()
            {
                HowLong();
                Console.WriteLine("This code runs when the object is destroyed");
            }
             
        }

        public void timerSam()
        {
            var sam = new sample();
            timer.Stop();
            Console.WriteLine(timer.Elapsed);
            Console.ReadLine();
        }
        
    }
}

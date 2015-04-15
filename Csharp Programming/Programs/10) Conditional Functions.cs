using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Programming.Programs
{
    public class _10__Conditional_Functions
    {
        [Conditional("DEBUG")]
        public void Trace(string traceMessage)
        {
            Console.WriteLine("[TRACE] - " + traceMessage);
        }
    }
}

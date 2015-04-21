using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Programming.Programs
{
    [Serializable]
    public class _18__Person
    {
        public string fname;
        public string lname;

        public _18__Person(string last, string first)
        {
            fname = first;
            lname = last;
        }
    }
}

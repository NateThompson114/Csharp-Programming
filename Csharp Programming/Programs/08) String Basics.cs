using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Programming.Programs
{
    public class _08__String_Basics
    {
        public void stringBasics()
        {
            string str = "This is an example of a string that " +
                             "spans multiple lines";
            Console.WriteLine("The string is {0}.",str);
            string part = str.Substring(1, 5);
            Console.WriteLine("The part is {0}", part);
            Console.WriteLine("The string starts with This: {0}", str.StartsWith("This"));
            Console.WriteLine("The first letter i is at {0}",str.IndexOf("i"));
        }
        
        
    }
}

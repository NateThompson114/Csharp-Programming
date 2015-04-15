using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Programming.Programs
{
    class _06__Access_Modifiers
    {
        class parent
        {
            public static string pName = "Samantha Brown"; //public can be accessed from anywhere, static means you do not have to create a instance of the class
            protected static string childSSN = "459-84-5176"; //protected means any class derived from the parent can access this data
            private static string parentSSN = "015-58-1568"; //private means only the parent can access this data

            public static void Print()
            {
                Console.WriteLine("Parent: {0}",pName);
            }
        }

        class child : parent
        {
            public static string cName = "Larry Brown";
            public static void Print()
            {
                //Console.WriteLine(parentSSN); //Reports that a private field cannot be accessed outside the class
                Console.WriteLine("Child: {0}", childSSN); //protected can be derived from parent
            }
        }

        class stranger
        {
            public static void Print()
            {
                //Console.WriteLine(pName); //despite the fact that x is in the parent class, it is not public access
                Console.WriteLine("Asked from parent: {0}", parent.pName); // adding the parent to console allows us to access the public information in the parent.
                Console.WriteLine("Asked from child: {0}",child.pName);
                Console.WriteLine("Asked child for name: {0}",child.cName);
            }
        }

        public void modifier()
        {
            parent.Print();
            child.Print();
            stranger.Print();
        }
    }
}

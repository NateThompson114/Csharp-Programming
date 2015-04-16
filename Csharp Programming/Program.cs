using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharp_Programming.Programs;
using Csharp_Class_Library;
using Csharp_Class_Library.Arithmetic;

namespace Csharp_Programming
{
    class Program
    {
        
        public static int testNum = 1;
        static public int DisplayMenu()
        {
            Console.ForegroundColor = System.ConsoleColor.Gray;
            Console.WriteLine("Udemy C# Programming Advanced: Test {0}",testNum);
            Console.WriteLine();
            Console.WriteLine("1. Delegate Multicast(Square/Cube Int)");
            Console.WriteLine("2. Action(Cube Int/double)");
            Console.WriteLine("3. Delegate Math(Subtraction/Addition Int)");
            Console.WriteLine("4. Interface I");
            Console.WriteLine("5. Interface II");
            Console.WriteLine("6. Access Modifier");
            Console.WriteLine("7. Destructors");
            Console.WriteLine("8. String Basics");
            Console.WriteLine("9. Partial Classes");
            Console.WriteLine("10. Conditional Functions");
            Console.WriteLine("11. Using a Dynamic Link Library");
            Console.WriteLine("12. Get File Information for Desktop");
            Console.WriteLine("13. Generics");
            Console.WriteLine("14. BLANK");
            var result = Console.ReadLine();
            try
            {
                return Convert.ToInt32(result);
            }
            catch (Exception)
            {

                Console.WriteLine("Incorrect choice: {0}", result);
            }
            return 0;
        }
        static void Main(string[] args)
        {
            var userInput = 0;
            ConsoleKeyInfo conkey;
            do
            {
                var numberGen = new Random();
                userInput = DisplayMenu();
                switch (userInput)
                {
                    case 1:
                        var md = new _01__Multicast_Delegates();
                        Console.WriteLine("Input a interger to square and cube");
                        var mdInput = Console.ReadLine();
                        md.MulticastDelegates(int.Parse(string.IsNullOrEmpty(mdInput)?"4":mdInput));

                        ender(1);
                        break;

                    case 2:
                        var ac = new _02__Actions();
                        Console.WriteLine("Input a interger to cube");
                        var acInput = Console.ReadLine();
                        ac.ActionCenter(double.Parse(string.IsNullOrEmpty(acInput)?"4":acInput));

                        ender(1);
                        break;

                    case 3:
                        var dm = new _03__Delegate_Math();
                        Console.WriteLine("Input interger X");
                        var x = Console.ReadLine();

                        Console.WriteLine("Input interger Y");
                        var y = Console.ReadLine();

                        dm.DoMath(int.Parse(string.IsNullOrEmpty(x) ? "4" : x),
                            int.Parse(string.IsNullOrEmpty(y) ? "4" : y));

                        ender(1);
                        break;

                    case 4:
                        var iProgram = new _04__Interface();
                        iProgram.ChairMessage();
                        
                        ender(1);
                        break;

                    case 5:
                        var iIF = new _05__Square();
                        Console.WriteLine("Input the length of one of side to your square");
                        var iIFinput = Console.ReadLine();
                        iIF.mySquare(double.Parse(string.IsNullOrEmpty(iIFinput)?"5.6":iIFinput));
                        
                        ender(1);
                        break;

                    case 6:
                        var am = new _06__Access_Modifiers();
                        am.modifier();
                        
                        ender(1);
                        break;

                    case 7:
                        _07__Destructors samp = new _07__Destructors();
                        samp.timerSam();

                        ender(1);
                        break;

                    case 8:
                        var sb = new _08__String_Basics();
                        sb.stringBasics();

                        ender(1);
                        break;

                    case 9:
                        var newemp = new _09__Split_Class();
                        newemp.Employee("John");

                        Console.WriteLine("The name of the person is {0}", newemp.GetFirst());

                        ender(1);
                        break;

                    case 10:
                        var trace = new _10__Conditional_Functions();
                        trace.Trace("This will only run in Debug Mode");
                        

                        ender(1);
                        break;

                    case 11:
                        var mycalc = new Calc();
                        var a = 6.798;
                        var b = 5;
                        var added = mycalc.Add(b , a);
                        var subtracted = mycalc.Sutract(a , b);
                        var c = Math.Round(numberGen.NextDouble(), 1) + numberGen.Next(100);
                        var d = Math.Round(numberGen.NextDouble(), 1) + numberGen.Next(100);
                        var e = Math.Round(numberGen.NextDouble(), 1) + numberGen.Next(100);
                        var f = Math.Round(numberGen.NextDouble(), 1) + numberGen.Next(100);
                        var g = Math.Round(numberGen.NextDouble(), 1) + numberGen.Next(100);
                        var h = Math.Round(numberGen.NextDouble(), 1) + numberGen.Next(100);
                        var i = Math.Round(numberGen.NextDouble(), 1) + numberGen.Next(100);
                        var j = Math.Round(numberGen.NextDouble(), 1) + numberGen.Next(100);
                        var massAdd = new AddingMachine();


                        Console.WriteLine("{0} + {1} = {2}",b,a,added);
                        Console.WriteLine("{0} + {1} = {2}",a,b,subtracted);
                        Console.WriteLine("Adding {0},{1},{2},{3},{4},{5},{6} and {7} equals {8}",c,d,e,f,g,h,i,j,massAdd.Add(c,d,e,f,g,h,i,j));

                        ender(1);
                        break;

                    case 12:
                        var fl = new _12___File_Information();
                        fl.Files();

                        ender(1);
                        break;

                    case 13:
                        var gl = new _13__Generics<int>(numberGen.Next(99));
                        var y1 = gl.Get();
                        Console.WriteLine("The value of y1 is {0}", y1);

                        var gl2 = new _13__Generics<String>("Hello World!");
                        var y2 = gl2.Get();
                        Console.WriteLine("The value of y2 is {0}", y2);

                        ender(1);
                        break;

                    case 14:
                        var cl = new _14__List_with_User_Control();
                        cl.carInfo();
                        
    
                        ender(1);
                        break;

                    default:
                        Console.WriteLine("No option found");
                        ender(0);
                        break;
                }
                conkey = Console.ReadKey();
            } while (conkey.Key != ConsoleKey.Escape);
        }

        public static string ender(int addToTest)
        {

            Console.WriteLine();
            Console.WriteLine("Press ESC to exit or any other key to continue");
            Console.WriteLine();
            testNum+= addToTest;
            return null;
        }
    }
}

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
            Console.WriteLine("13. BLANK");
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
                userInput = DisplayMenu();
                switch (userInput)
                {
                    case 1:
                        var md = new _01__Multicast_Delegates();
                        Console.WriteLine("Input a interger to square and cube");
                        var mdInput = Console.ReadLine();
                        md.MulticastDelegates(int.Parse(string.IsNullOrEmpty(mdInput)?"4":mdInput));

                        ender();
                        break;

                    case 2:
                        var ac = new _02__Actions();
                        Console.WriteLine("Input a interger to cube");
                        var acInput = Console.ReadLine();
                        ac.ActionCenter(double.Parse(string.IsNullOrEmpty(acInput)?"4":acInput));

                        ender();
                        break;

                    case 3:
                        var dm = new _03__Delegate_Math();
                        Console.WriteLine("Input interger X");
                        var x = Console.ReadLine();

                        Console.WriteLine("Input interger Y");
                        var y = Console.ReadLine();

                        dm.DoMath(int.Parse(string.IsNullOrEmpty(x) ? "4" : x),
                            int.Parse(string.IsNullOrEmpty(y) ? "4" : y));

                        ender();
                        break;

                    case 4:
                        var iProgram = new _04__Interface();
                        iProgram.ChairMessage();
                        
                        ender();
                        break;

                    case 5:
                        var iIF = new _05__Square();
                        Console.WriteLine("Input the length of one of side to your square");
                        var iIFinput = Console.ReadLine();
                        iIF.mySquare(double.Parse(string.IsNullOrEmpty(iIFinput)?"5.6":iIFinput));
                        
                        ender();
                        break;

                    case 6:
                        var am = new _06__Access_Modifiers();
                        am.modifier();
                        
                        ender();
                        break;

                    case 7:
                        _07__Destructors samp = new _07__Destructors();
                        samp.timerSam();

                        ender();
                        break;

                    case 8:
                        var sb = new _08__String_Basics();
                        sb.stringBasics();

                        ender();
                        break;

                    case 9:
                        var newemp = new _09__Split_Class();
                        newemp.Employee("John");

                        Console.WriteLine("The name of the person is {0}", newemp.GetFirst());

                        ender();
                        break;

                    case 10:
                        var trace = new _10__Conditional_Functions();
                        trace.Trace("This will only run in Debug Mode");
                        

                        ender();
                        break;

                    case 11:
                        var mycalc = new Calc();
                        var a = 6.798;
                        var b = 5;
                        var added = mycalc.Add(b , a);
                        var subtracted = mycalc.Sutract(a , b);
                        var numberGen = new Random();
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

                        ender();
                        break;

                    case 12:
                        var fl = new _12___File_Information();
                        fl.Files();

                        ender();
                        break;

                    case 13:
                        

                        ender();
                        break;

                    default:
                        Console.WriteLine("No option found");
                        ender2();
                        break;
                }
                conkey = Console.ReadKey();
            } while (conkey.Key != ConsoleKey.Escape);
        }

        public static string ender()
        {

            Console.WriteLine();
            Console.WriteLine("Press ESC to exit or any other key to continue");
            Console.WriteLine();
            testNum++;
            return null;
        }
        public static string ender2()
        {

            Console.WriteLine();
            Console.WriteLine("Press ESC to exit or any other key to continue");
            Console.WriteLine();
            return null;
        }
    }
}

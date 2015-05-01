using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
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
            Console.WriteLine("13. Generic List");
            Console.WriteLine("14. List with user controls");
            Console.WriteLine("15. Generic Interface");
            Console.WriteLine("16. Generic Dictonary");
            Console.WriteLine("17. Lambda Expressions");
            Console.WriteLine("18. Serialization");
            Console.WriteLine("19. Event Log");
            Console.WriteLine("20. Threads");
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

                        Ender(1);
                        break;

                    case 2:
                        var ac = new _02__Actions();
                        Console.WriteLine("Input a interger to cube");
                        var acInput = Console.ReadLine();
                        ac.ActionCenter(double.Parse(string.IsNullOrEmpty(acInput)?"4":acInput));

                        Ender(1);
                        break;

                    case 3:
                        var dm = new _03__Delegate_Math();
                        Console.WriteLine("Input interger X");
                        var x = Console.ReadLine();

                        Console.WriteLine("Input interger Y");
                        var y = Console.ReadLine();

                        dm.DoMath(int.Parse(string.IsNullOrEmpty(x) ? "4" : x),
                            int.Parse(string.IsNullOrEmpty(y) ? "4" : y));

                        Ender(1);
                        break;

                    case 4:
                        var iProgram = new _04__Interface();
                        iProgram.ChairMessage();
                        
                        Ender(1);
                        break;

                    case 5:
                        var iIF = new _05__Square();
                        Console.WriteLine("Input the length of one of side to your square");
                        var iIFinput = Console.ReadLine();
                        iIF.mySquare(double.Parse(string.IsNullOrEmpty(iIFinput)?"5.6":iIFinput));
                        
                        Ender(1);
                        break;

                    case 6:
                        var am = new _06__Access_Modifiers();
                        am.modifier();
                        
                        Ender(1);
                        break;

                    case 7:
                        _07__Destructors samp = new _07__Destructors();
                        samp.timerSam();

                        Ender(1);
                        break;

                    case 8:
                        var sb = new _08__String_Basics();
                        sb.stringBasics();

                        Ender(1);
                        break;

                    case 9:
                        var newemp = new _09__Split_Class();
                        newemp.Employee("John");

                        Console.WriteLine("The name of the person is {0}", newemp.GetFirst());

                        Ender(1);
                        break;

                    case 10:
                        var trace = new _10__Conditional_Functions();
                        trace.Trace("This will only run in Debug Mode");
                        

                        Ender(1);
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

                        Ender(1);
                        break;

                    case 12:
                        var fl = new _12___File_Information();
                        fl.Files();

                        Ender(1);
                        break;

                    case 13:
                        var gl = new _13__Generics<int>(numberGen.Next(99));
                        var y1 = gl.Get();
                        Console.WriteLine("The value of y1 is {0}", y1);

                        var gl2 = new _13__Generics<String>("Hello World!");
                        var y2 = gl2.Get();
                        Console.WriteLine("The value of y2 is {0}", y2);

                        Ender(1);
                        break;

                    case 14:
                        var cl = new _14__List_with_User_Control();
                        cl.carInfo();
                       
                        Ender(1);
                        break;

                    case 15:
                        var gi = new _15_Generic_Interface_User<int>();
                        gi.Show();

                        Ender(1);
                        break;

                    case 16:

                        //var dictonaryExample = new Dictionary<string, string>();
                        //dictonaryExample.Add("First", Console.ReadLine());
                        //dictonaryExample.Add("Second", Console.ReadLine());

                        //Console.WriteLine("The value stored under key first is {0}",dictonaryExample["First"]);
                        //Console.WriteLine("The value stored under key second is {0}",dictonaryExample["Second"]);

                        
                        var de = new _16__Generic_Dictionarie.multiLineMessenger();

                        Console.WriteLine("Input a sentence you would like to \"encrypt\"");
                        var deInput = de.multiLine(Console.ReadLine(), true);
                        Console.WriteLine(deInput);
                        Console.WriteLine();
                        Console.WriteLine("Decrypting");
                        Console.WriteLine(de.multiLine(deInput,false));

                        Ender(1);
                        break;

                    case 17:
                        Func<string> myFunc = () => "Hello World";
                        Console.WriteLine("myFunc returns {0}",myFunc());
                        
                        Func<int, int, int> myFunc2 = (int aa, int bb) =>(aa + bb);
                        Console.WriteLine("The sum of 4 and 10 is {0}", myFunc2(4, 10));

                        var ld = new _17__Lambda();

                        var myFunc3 = ld.Adder();
                        var myFunc4 = ld.Square();
                        
                        Console.WriteLine("My variable of {0} store in the ld class, modified by lambda my var becomes {1} when run through added and {2} when squared",ld.Get(),myFunc3(),myFunc4(ld.Get()));

                        var ldn1 = numberGen.Next(10) + numberGen.NextDouble();
                        var ldn2 = numberGen.Next(10) + numberGen.NextDouble();
                        var ldn3 = numberGen.Next(4);

                        dynamic xx = ld.Divide(ldn1, ldn2, ldn3);
                        dynamic yy = ld.Multiply(ldn1, ldn2, ldn3);

                        Console.WriteLine("{0} / {1} then rounded to {2} decimals = {3}", ldn1, ldn2, ldn3, xx);
                        Console.WriteLine("{0} x {1} then rounded to {2} decimals = {3}", ldn1, ldn2, ldn3, yy);


                        Ender(1);
                        break;

                    case 18:
                        var file = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) +
                                      @"\person.person";

                        var per = new _18__Person("smith", "john");
                        Stream writeoject =
                            File.Create(file);
                        BinaryFormatter nbf = new BinaryFormatter();
                        nbf.Serialize(writeoject,per);
                        writeoject.Close();

                        Stream readObject = File.OpenRead(file);
                        var newper2 = (_18__Person) nbf.Deserialize(readObject);
                        readObject.Close();

                        Console.WriteLine("The file, person.person contains the name {0}" +
                                          " {1}",newper2.fname,newper2.lname);

                        Ender(1);
                        break;

                    case 19:

                        var sourceofevent = "Simple Console App";
                        var logName = "Application";
                        var logmessage = "The simple console app has executed.";
                        if (!EventLog.SourceExists(sourceofevent))
                        {
                            EventLog.CreateEventSource(sourceofevent,logName);
                        }
                        EventLog.WriteEntry(sourceofevent,logmessage,EventLogEntryType.Information);

                        Ender(1);
                        break;

                    case 20:
                        var program = new _20__Threads();
                        var newthread = new Thread(new ThreadStart(program.Worker));
                        newthread.Start();
                        newthread.Join();
                        Console.WriteLine("Back in main");

                        Ender(1);
                        break;
                    default:
                        Console.WriteLine("No option found");
                        Ender(0);
                        break;
                }
                conkey = Console.ReadKey();
            } while (conkey.Key != ConsoleKey.Escape);
        }

        public static string Ender(int addToTest)
        {

            Console.WriteLine();
            Console.WriteLine("Press ESC to exit or any other key to continue");
            Console.WriteLine();
            testNum += addToTest;
            return null;
        }
    }
}

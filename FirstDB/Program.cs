using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Csharp_FirstDB
{
    class Program
    {
        public static int testNum = 1;
        static public int DisplayMenu()
        {
            Console.WriteLine("Udemy C# Data Munipulation: Test {0}", testNum);
            Console.WriteLine();
            Console.WriteLine("1. SQL Connection");
            Console.WriteLine("2. Array Parse with Linq");
            Console.WriteLine("3. XML Parse with Linq");
            Console.WriteLine("4. String Parse with Linq");
            Console.WriteLine("5. Linq to SQL");
            Console.WriteLine("6. Details View Control");
            Console.WriteLine("7. BLANK");
            var result = Console.ReadLine();
            try
            {
                return Convert.ToInt32(result);
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect choice: {0}",result);
            }
            return 0;
        }
        static void Main(string[] args)
        {
            var userInput = 0;
            var conkey = new ConsoleKeyInfo();
            const string connectionString = @"Data Source=(localdb)\ProjectsV12;" +
                                                       "Initial " +
                                                       "Catalog=MyFirstDatabase;" +
                                                       "Integrated Security=True;" +
                                                       "Connect Timeout=30;" +
                                                       "Encrypt=False;" +
                                                       "TrustServerCertificate=False";
            do
            {
                var numberGen = new Random();
                userInput = DisplayMenu();
                Console.WriteLine();
                switch (userInput)
                {
                    case 1:

                        /*SQL Server Connections*/
                       
                        var command = "Select * from dbo.People";
                        var connection = new SqlConnection(connectionString);
                        var sqlCommand = new SqlCommand(command, connection);

                        using (connection)
                        {
                            try
                            {
                                connection.Open();
                                var reader = sqlCommand.ExecuteReader();
                                while (reader.Read())
                                {
                                    Console.WriteLine("{0}) {1}, {2}", reader[0], reader[1], reader[2]);
                                }

                            }
                            catch (Exception ex)
                            {

                                Console.WriteLine(ex.Message);
                            }
                        }

                        Ender(1);
                        break;
                    case 2:

                        /*Linq*/
                        Console.WriteLine("How many items in your array?");
                        var arr = new double[int.Parse(Console.ReadLine())];
                        for (int i = 0; i < arr.Length; i++)
                        {
                            Console.WriteLine("{0}/{1} is equal to?", i + 1, arr.Length);
                            arr[i] = Double.Parse(Console.ReadLine());
                            Console.WriteLine();
                        }

                        Console.WriteLine("What is the low side vale you want? 0?");
                        var lowside = Console.ReadLine();
                        var lsInt = string.IsNullOrEmpty(lowside) ? 0 : int.Parse(lowside);

                        Console.WriteLine("What is the high side? 10?");
                        var highSide = Console.ReadLine();
                        var hsInt = string.IsNullOrEmpty(highSide) ? 10 : int.Parse(highSide);

                        var vales = from num in arr where (num >= lsInt && num <= hsInt) select num;
                        foreach (double d in vales)
                        {
                            Console.WriteLine("The value is {0}", d.ToString());
                        }

                        Ender(1);
                        break;
                    case 3:

                        /* XML Parsing with Linq */
                        const string xmlLocal = @"C:\Users\nthompson\Documents\Visual Studio 2013\Projects\Csharp Programming\FirstDB\AppData\People.xml";
                        var userFile = XElement.Load(xmlLocal);
                        IEnumerable<string> deskTopUser = from eachuser in userFile.Descendants("user")
                                                          select (string)eachuser.Attribute("fullname");

                        foreach (var userName in deskTopUser)
                        {
                            Console.WriteLine("The name is {0}", userName);
                        }

                        Ender(1);
                        break;
                    case 4:

                        Console.WriteLine("Input the string that you would like to search");
                        var userText = Console.ReadLine();

                        Console.WriteLine("Input the word you would like to search the string for");
                        var searchTerm = Console.ReadLine();
                        var search = searchTerm;

                        Console.WriteLine("Case sensitive? (Yes/No) ~defaults yes");
                        var caseSen = Console.ReadLine();

                        if (!string.IsNullOrEmpty(caseSen) && caseSen.ToLower().StartsWith("n") )
                        {
                            userText = userText.ToLower();
                            searchTerm = searchTerm.ToLower();
                        }

                        var stringARR = userText.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                        var occurences = from word in stringARR where word == searchTerm select word;

                        Console.WriteLine("The word {0} occures {1}", search, occurences.Count());

                        Ender(1);
                        break;
                    case 5:

                        var myid = 0;
                        var ds = new DataSet();
                        var na = new SqlDataAdapter("select * from dbo.FullNamePeople", connectionString);

                        na.Fill(ds, "dbo.FullNamePeople");
                        var dt = ds.Tables["dbo.FullNamePeople"];

                        dynamic results = null;

                        var foundRecord = 0;
                        do
                        {
                            Console.WriteLine("Enter a id you wish to lookup:");
                            var myidInput = Console.ReadLine();
                            myid = string.IsNullOrEmpty(myidInput) ? 0 : int.Parse(myidInput);
                            try
                            {
                                results = from ro in dt.AsEnumerable()
                                          where (ro.Field<int>("id") == myid)
                                          select ro.Field<string>("firstName");
                                foreach (string result in results)
                                {
                                    foundRecord++;
                                }
                                if (foundRecord == 0)
                                {
                                    throw new ArgumentNullException();
                                }
                            }
                            catch (Exception)
                            {

                                Console.WriteLine("No matching id: {0}\n Try again...",myid);
                                myid = 0;
                            }
                            
                        } while (foundRecord == 0);
                        

                        foreach (string fname in results)
                        {
                            Console.WriteLine("The name is {0}", fname);
                        }

                        Ender(1);
                        break;
                    case 6:

                        Ender(0);
                        Console.WriteLine("Option {0} is not implemented yet", userInput);
                        continue;
                    case 7:

                        Ender(0);
                        Console.WriteLine("Option {0} is not implemented yet", userInput);
                        continue;
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

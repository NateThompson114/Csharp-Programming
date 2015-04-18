using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Programming.Programs
{
    class _16__Generic_Dictionarie
    {
        public class multiLineMessenger
        {
            public string multiLine(string input, bool encrypt)
            {
                var output = "";
                if (encrypt)
                {
                    var stringList = new List<string>();
                    var encryptedString = new List<string>();
                    var count = 0;
                    do
                    {
                        if (input.Count() - count > 5)
                        {
                            stringList.Add(input.Substring(count, 5));
                            count += 5;
                        }
                        else
                        {
                            stringList.Add(input.Substring(count));
                            count += input.Count() - count;
                        }
                    } while (input.Length != count);

                    foreach (var cluster in stringList)
                    {
                        var eML = new Messenger();
                        encryptedString.Add(eML.encryptor(cluster));
                    }
                    output = String.Join(" ", encryptedString);
                }
                else
                {
                    var encrptList = input.Split(' ');
                    var cleanedList = new List<string>();
                    foreach (var s in encrptList)
                    {
                        var dML = new Messenger();
                        cleanedList.Add(dML.decryptor(s));
                    }

                    output = String.Join("", cleanedList);
                }

                return output;
            }
        }
        public class Messenger
        {
            
            public string encryptor(string input)
            {
                var rnd = new Random();
                var key = rnd.Next(10, 70);
                var charArray = input.ToLower().ToCharArray();
                var encryptedList = new List<string>();
                var preFinal = "";
                string encrytedString;

                var alphabetL = new Dictionary<string,int>();
                alphabetL.Add("a", 1 + key);
                alphabetL.Add("b", 2 + key);
                alphabetL.Add("c", 3 + key);
                alphabetL.Add("d", 4 + key);
                alphabetL.Add("e", 5 + key);
                alphabetL.Add("f", 6 + key);
                alphabetL.Add("g", 7 + key);
                alphabetL.Add("h", 8 + key);
                alphabetL.Add("i", 9 + key);
                alphabetL.Add("j", 10 + key);
                alphabetL.Add("k", 11 + key);
                alphabetL.Add("l", 12 + key);
                alphabetL.Add("m", 13 + key);
                alphabetL.Add("n", 14 + key);
                alphabetL.Add("o", 15 + key);
                alphabetL.Add("p", 16 + key);
                alphabetL.Add("q", 17 + key);
                alphabetL.Add("r", 18 + key);
                alphabetL.Add("s", 19 + key);
                alphabetL.Add("t", 20 + key);
                alphabetL.Add("u", 21 + key);
                alphabetL.Add("v", 22 + key);
                alphabetL.Add("w", 23 + key);
                alphabetL.Add("x", 24 + key);
                alphabetL.Add("y", 25 + key);
                alphabetL.Add("z", 26 + key);
                alphabetL.Add(" ", 27 + key);

                encryptedList.Add(key.ToString());
                foreach (var c in charArray)
                {
                    var cs = alphabetL[c.ToString()].ToString();
                    encryptedList.Add(cs.Length != 2 ? "0"+cs : cs);
                }
                foreach (var item in encryptedList)
                {
                    preFinal += item;
                }

                encrytedString = (Int64.Parse(preFinal)*9).ToString();
                return encrytedString;
            }

            public string decryptor(string input)
            {
                var stage1 = Int64.Parse(input)/9;
                var key = int.Parse(stage1.ToString().Substring(0, 2));
                var encoded = stage1.ToString().Substring(2, stage1.ToString().Length-2);
                var encodeList = new List<string>();
                var result = "";

                var alphabet = new Dictionary<int, string>();
                alphabet.Add(1, "a");
                alphabet.Add(2, "b");
                alphabet.Add(3, "c");
                alphabet.Add(4, "d");
                alphabet.Add(5, "e");
                alphabet.Add(6, "f");
                alphabet.Add(7, "g");
                alphabet.Add(8, "h");
                alphabet.Add(9, "i");
                alphabet.Add(10, "j");
                alphabet.Add(11, "k");
                alphabet.Add(12, "l");
                alphabet.Add(13, "m");
                alphabet.Add(14, "n");
                alphabet.Add(15, "o");
                alphabet.Add(16, "p");
                alphabet.Add(17, "q");
                alphabet.Add(18, "r");
                alphabet.Add(19, "s");
                alphabet.Add(20, "t");
                alphabet.Add(21, "u");
                alphabet.Add(22, "v");
                alphabet.Add(23, "w");
                alphabet.Add(24, "x");
                alphabet.Add(25, "y");
                alphabet.Add(26, "z");
                alphabet.Add(27, " ");

                var count = 0;

                do
                {
                    encodeList.Add(encoded.Substring(count,2));
                    count += 2;
                } while (encoded.Length != count);

                foreach (var g in encodeList)
                {
                    result += alphabet[int.Parse(g) - key];
                }

                return result;
            }
        }
    }
}

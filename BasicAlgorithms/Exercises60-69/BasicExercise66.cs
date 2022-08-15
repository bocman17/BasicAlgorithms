using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise66
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("Daniel", "Tasja"));
            Console.WriteLine(Test("Tomas", "Bocman"));
            Console.WriteLine(Test("Ankara", "Acapulco"));
            Console.WriteLine(Test("boc", "man"));
            Console.WriteLine(Test("globen", "kuken"));
            Console.WriteLine(Test(new string[] { "Tomas", "Kilimangaro", "Pocahontas", "McDonald" }));
            Console.WriteLine(Test(new string[] {"Tomas" , "Bocman", "Tasja", "Daniel"}));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new string from two given string
        // one is shorter and another is longer. The format of the new string
        // will be long string + short string + long string.

        public static string Test(string s1, string s2)
        {
            {
                string[] strArr = new string[] { s1, s2 };
                strArr = strArr.OrderByDescending(s => s.Length).ToArray();
                string output = strArr[0];
                output = strArr[0] + strArr[1] + strArr[0];
                return output;
            }
        }

        public static string Test(string[] strArr)
        {
            {
                strArr = strArr.OrderByDescending(s => s.Length).ToArray();
                string output = strArr.First();
                for (int i = 1; i < strArr.Length; i++)
                {
                    output += strArr[i] + strArr.First();
                }

                return output;
            }
        }
    }
}

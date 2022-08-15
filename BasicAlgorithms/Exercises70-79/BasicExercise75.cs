using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise75
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new string[] {"Hello", "Python", "Tasja", "Tomas"}));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new string taking 3 characters
        // from the middle of a given string at least 3.

        public static string Test(string[] strArr, int n = 3)
        {
            strArr = strArr.Where(s => s.Length > n).Select
                (s => s.Substring(s.Length / 2 - (n / 2), n)).ToArray();
            string output = String.Join(", ", strArr);
            return output;
        }
    }
}

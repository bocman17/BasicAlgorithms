using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise73
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new string[] {"Hello", "Python", "on", "o"}, 3));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new string using the
        // first and last n characters from a given string of length at least n.

        public static string Test(string[] strArr, int n)
        {
            strArr = strArr.Where(s => s.Length > n).Select(s => s[..n] + s[^n..]).ToArray();
            string output = String.Join(", ", strArr);
            return output;
        }
    }
}

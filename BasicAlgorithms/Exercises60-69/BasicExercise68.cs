using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise68
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new string[] {"Daniel", "Tasja"}));
            Console.WriteLine(Test(new string[] {"JS", "Python"}));
            Console.WriteLine(Test(new string[] {"JS", "Python", "Kotlin", "Sequel"}));
            Console.ReadLine();
        }
        // Write a C# Sharp program to move the first two characters to the
        // end of a given string of length at least two.

        public static string Test(string[] strArr, int n = 2)
        {
            strArr = strArr.Where(s => s.Length > n).Select(s => s[n..] + s[..n]).ToArray();
            string output = String.Join(", ", strArr);
            return output;
        }
    }
}

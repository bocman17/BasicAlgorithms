using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise70
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new string[] { "Daniel", "Tasja" }));
            Console.WriteLine(Test(new string[] { "JS", "Python" }));
            Console.WriteLine(Test(new string[] { "JS", "Python", "Kotlin", "Sequel" }));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new string without the first and last
        // character of a given string of any length.

        public static string Test(string[] strArr)
        {
            strArr = strArr.Select
                (s => s[1..^1]).ToArray();
            string output = String.Join(", ", strArr);
            return output;
        }
    }
}

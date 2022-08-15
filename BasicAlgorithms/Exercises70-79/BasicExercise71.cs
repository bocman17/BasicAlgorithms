using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise71
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new string[] { "Daniel", "Tasja" }));
            Console.WriteLine(Test(new string[] { "JS", "Python" }));
            Console.WriteLine(Test(new string[] { "Python", "Kotlin", "Sequel" }));
            Console.WriteLine(Test(new string[] { "Pythonolygocal", "Kotlin", "Sequel" }));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new string using the two middle
        // characters of a given string of even length (at least 2)

        public static string Test(string[] strArr, int n = 2)
        {
            strArr = strArr.Where(s => s.Length > n).Select
                (s => s.Substring(s.Length/2 - (n / 2), n)).ToArray();
            string output = String.Join(", ", strArr);
            return output;
        }
    }
}

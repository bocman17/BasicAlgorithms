using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise72
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("Hello"));
            Console.WriteLine(Test("Python"));
            Console.WriteLine(Test("on"));
            Console.WriteLine(Test("o"));

            Console.ReadLine();
        }
        // Write a C# Sharp program to check if a given string ends with "on".

        public static bool Test(string str, string end = "on")
        {
            return str.EndsWith(end);
        }
    }
}

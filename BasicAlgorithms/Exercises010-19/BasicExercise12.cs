using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise12
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("C# Sharp", "C#"));
            Console.WriteLine(Test("C#", "C#"));
            Console.WriteLine(Test("C++", "C#"));
            Console.ReadLine();
        }
        //Write a C# Sharp program to check if a given string starts with 'C#' or not.

        public static bool Test(string s, string toCheck)
        {
            return s.StartsWith(toCheck);
        }
    }
}

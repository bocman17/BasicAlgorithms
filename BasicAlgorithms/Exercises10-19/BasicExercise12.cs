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
            Console.WriteLine(CheckIfStringStartsWithString("C# Sharp", "C#"));
            Console.WriteLine(CheckIfStringStartsWithString("C#", "C#"));
            Console.WriteLine(CheckIfStringStartsWithString("C++", "C#"));
            Console.ReadLine();
        }
        //Write a C# Sharp program to check if a given string starts with 'C#' or not.

        public static bool CheckIfStringStartsWithString(string s, string toCheck)
        {
            return s.StartsWith(toCheck);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise9
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddLastCharToFrontAndBack("Red"));
            Console.WriteLine(AddLastCharToFrontAndBack("Green"));
            Console.WriteLine(AddLastCharToFrontAndBack("1"));
            Console.ReadLine();
        }

        //Write a C# Sharp program to create a new string with the
        //last char added at the front and back of a given string of length 1 or more.

        public static string AddLastCharToFrontAndBack(string s)
        {
            return s.Substring(s.Length - 1) + s + s.Substring(s.Length - 1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise65
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("Daniel"));
            Console.WriteLine(Test("Tasja"));
            Console.WriteLine(Test("Hello"));
            Console.WriteLine(Test("Mariupol"));
            Console.WriteLine(Test("Prototype"));
            Console.WriteLine(Test("Hi"));
            Console.WriteLine(Test("a"));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new string without
        // the first and last character of a given string of length at least two.

        public static string Test(string str, int count = 4)
        {
            if (str.Length <= count * 2) return str;
            else return str[count..^count];
        }
    }
}

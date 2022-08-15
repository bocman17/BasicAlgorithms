using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise61
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("Daniel", "Tasja"));
            Console.WriteLine(Test("Daniela", "Tasja"));
            Console.ReadLine();
        }
        // Write a C# Sharp program to insert a given string into middle of the
        // another given string of length 4.

        public static string Test(string s1, string s2)
        {
           return s1.Insert(s1.Length / 2, s2);
        }
    }
}

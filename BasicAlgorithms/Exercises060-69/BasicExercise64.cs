using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise64
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("Daniel"));
            Console.WriteLine(Test("Tasja"));
            Console.WriteLine(Test("Hello"));
            Console.WriteLine(Test("Hi"));
            Console.WriteLine(Test("a"));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new
        // string of the first half of a given string of even length.

        public static string Test(string str)
        {
            int half = str.Length / 2;
            return str[..half];
        }
    }
}

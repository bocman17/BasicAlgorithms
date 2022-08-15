using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise30
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("abcd"));
            Console.WriteLine(Test("abc"));
            Console.WriteLine(Test("a"));
            Console.ReadLine();
        }
        //Write a C# Sharp program to create a string like "aababcabcd"
        //from a given string "abcd". 

        public static string Test(string s)
        {
            string output = string.Empty;
            for (int i = 0; i < s.Length + 1; i++)
            {
                output += s[..i];
            }
            return output;
        }
    }
}

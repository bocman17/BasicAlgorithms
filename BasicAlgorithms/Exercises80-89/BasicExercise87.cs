using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise87
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("abcab"));
            Console.WriteLine(Test("python"));
            Console.WriteLine(Test("aacda"));
            Console.WriteLine(Test("jython"));
            Console.WriteLine(Test("a"));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new string from a given string.
        // If the first or first two characters is 'a', return the string without
        // those 'a' characters otherwise return the original given string.

        public static string Test(string str, char a = 'a', int n = 2)
        {
            if (String.IsNullOrEmpty(str)) return "Invalid string.";
            else if (str.Length < n) return str;

            string output = str;

            for (int i = 1; i <= n; i++)
            {
                if (str[i - 1] == a) output = str[i..];
            }
            return output;
        }
    }
}

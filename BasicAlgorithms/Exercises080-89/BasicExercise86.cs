using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise86
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("abcab"));
            Console.WriteLine(Test("python"));
            Console.WriteLine(Test("abcda"));
            Console.WriteLine(Test("jython"));
            Console.WriteLine(Test("a"));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new string from a given
        // string without the first and last character if the first or
        // last characters are 'a' otherwise return the original given string. 

        public static string Test(string str, char a = 'a')
        {
            if (str is null || str.Length == 0) return "Invalid string.";
            if (str.ToLower().StartsWith(a)) str = str[1..];
            if (str.ToLower().EndsWith(a)) str = str[..^1];
            return str;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise81
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("abab"));
            Console.WriteLine(Test("abcdef"));
            Console.WriteLine(Test("xyzsderxy"));
            Console.WriteLine(Test("aa"));
            Console.WriteLine(Test("a"));
            Console.ReadLine();
        }
        // Write a C# Sharp program to check whether the first two characters
        // and last two characters of a given string are same.

        public static bool Test(string str, int n = 2)
        {
            if (str.Length < n) return false;
            else if (str.StartsWith(str[..n]) == str.EndsWith(str[..n])) return true;
            return false;
        }
    }
}

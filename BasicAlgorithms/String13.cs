using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class String13
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveCharInStrExceptFirstAndLastChar("xxHxix", 'x'));
            Console.WriteLine(RemoveCharInStrExceptFirstAndLastChar("abxdddca", 'a'));
            Console.WriteLine(RemoveCharInStrExceptFirstAndLastChar("xabjbhtrb", 'b'));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new string
        // from a give string where a specified character have
        // been removed except starting and ending position of the given string.

        public static string RemoveCharInStrExceptFirstAndLastChar(string s, char c)
        {
            for (int i = 1; i < s.Length-2; i++)
            {
                if (s[i] == c) s = s.Remove(i, 1);
            }
            return s;
        }
    }
}

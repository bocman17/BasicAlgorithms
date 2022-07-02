using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class String3
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SwapFirstAndLast("abcd"));
            Console.WriteLine(SwapFirstAndLast("a"));
            Console.WriteLine(SwapFirstAndLast("xy"));
            Console.ReadLine();
        }

        //Write a C# Sharp program to exchange the first and
        //last characters in a given string and return the new string.

        public static string SwapFirstAndLast(string s)
        {
            return s.Length > 1 ?
                s.Substring(s.Length - 1) + s.Substring(1, s.Length - 2) + s.Substring(0, 1)
                : s;
        }
    }
}

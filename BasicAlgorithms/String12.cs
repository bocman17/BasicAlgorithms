using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class String12
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ModifyString("abcd"));
            Console.WriteLine(ModifyString("abc"));
            Console.WriteLine(ModifyString("a"));
            Console.ReadLine();
        }
        //Write a C# Sharp program to create a string like "aababcabcd"
        //from a given string "abcd". 

        public static string ModifyString(string s)
        {
            string output = string.Empty;
            for (int i = 0; i < s.Length + 1; i++)
            {
                output += s.Substring(0, i);
            }
            return output;
        }
    }
}

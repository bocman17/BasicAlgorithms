using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise26
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CopySubStringNtimes("Python", 2));
            Console.WriteLine(CopySubStringNtimes("Python", 3));
            Console.WriteLine(CopySubStringNtimes("JS", 3));
            Console.ReadLine();
        }
        //Write a C# Sharp program to create a new string which
        //is n (non-negative integer) copies of the the first 3
        //characters of a given string. If the length of the given
        //string is less than 3 then return n copies of the string.

        public static string CopySubStringNtimes(string s, int n, int chars = 3)
        {
            string output = string.Empty;

            if (s.Length < chars)
            {
                for (int i = 0; i < n; i++)
                {
                    output += s;
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    output += s[..(chars)];
                }
            }
            return output;
        }
    }
}

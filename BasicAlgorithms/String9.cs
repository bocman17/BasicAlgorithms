using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class String9
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CopyStringNtimes("JS", 2));
            Console.WriteLine(CopyStringNtimes("JS", 3));
            Console.WriteLine(CopyStringNtimes("JS", 1));
            Console.ReadLine();
        }
        //Write a C# Sharp program to create a new string which is n
        //(non-negative integer) copies of a given string.

        public static string CopyStringNtimes(string s, int n)
        {
            string output = string.Empty;
            for(int i = 0; i < n; i++)
            {
                output += s;
            }
            return output;
        }
    }
}

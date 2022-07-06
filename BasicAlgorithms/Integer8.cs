using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class Integer8
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountOfEqualSubString("abcdefgh", "abijsklm"));
            Console.WriteLine(CountOfEqualSubString("abcde", "osuefrcd"));
            Console.WriteLine(CountOfEqualSubString("pqrstuvwx", "pqkdiewx"));
            Console.WriteLine(CountOfEqualSubString("tasja", "tasja", 3));
            Console.ReadLine();
        }
        //Write a C# Sharp program to compare two given strings and return the number
        //of the positions where they contain the same length 2 substring.

        public static int CountOfEqualSubString(string s1, string s2, int n = 2)
        {
            int count = 0;
            for (int i = 0; i < s1.Length - n + 1; i++)
            {
                string temp = s1.Substring(i, n);
                for (int j = 0; j < s2.Length - n + 1; j++)
                {
                    if (temp.Equals(s2.Substring(j, n))) count++;
                }
            }
            return count;
        }
    }
}

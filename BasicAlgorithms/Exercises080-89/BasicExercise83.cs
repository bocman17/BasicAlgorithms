using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise83
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("abc"));
            Console.WriteLine(Test("Python"));
            Console.WriteLine(Test("J"));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new string using 3 copies of
        // the first 2 characters of a given string. If the length of the
        // given string is less than 2 use the whole string. 

        public static string Test(string str, int chars = 2, int repeat = 3)
        {
            string output = string.Empty;

            if (str.Length < chars)
            {
                for (int i = 0; i < repeat; i++)
                {
                    output += str;
                }
            }
            else
            {
                for (int i = 0; i < repeat; i++)
                {
                    output += str[..2];
                }
            }
            return output;
        }
    }
}

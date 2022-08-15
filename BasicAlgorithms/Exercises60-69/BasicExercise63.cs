using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise63
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("Daniel"));
            Console.WriteLine(Test("Tasja"));
            Console.WriteLine(Test("Hello"));
            Console.WriteLine(Test("Hi"));
            Console.WriteLine(Test("a"));
            Console.WriteLine(Test(""));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new string using first
        // two characters of a given string. If the string length is less
        // than 2 then return the original string..

        public static string Test(string str, int n = 2, int copies = 1)
        {
            string output = "";
            if (str.Length < n)
            {
                for (int i = 0; i < copies; i++)
                {
                    output += str;
                }
            }
            else
            {
                for (int i = 0; i < copies; i++)
                {
                    output += str[..n];
                }
            }
            return output;
        }  
    }
}

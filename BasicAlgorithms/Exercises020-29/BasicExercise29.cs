using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise29
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("Python"));
            Console.WriteLine(Test("PHP"));
            Console.WriteLine(Test("JS"));
            Console.ReadLine();
        }
        //Write a C# Sharp program to create a new string made
        //of every other character starting with the first from a given string.

        public static string Test(string s)
        {
            string output = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if(i % 2 == 0)
                {
                    output += s[i];
                }
            }
            return output;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise25
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("JS", 2));
            Console.WriteLine(Test("JS", 3));
            Console.WriteLine(Test("JS", 1));
            Console.WriteLine(Test("daniel", 5));
            Console.ReadLine();
        }
        //Write a C# Sharp program to create a new string which is n
        //(non-negative integer) copies of a given string.

        public static string Test(string s, int n)
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

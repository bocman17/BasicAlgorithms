using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise37
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("Python", new int[] {0,1,4,5,8,9}));
            Console.WriteLine(Test("JavaScript", new int[] {0,1,4,5,8,9}));
            Console.WriteLine(Test("HTML", new int[] {0,1,4,5,8,9}));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new string of the characters at indexes
        // 0,1, 4,5, 8,9 ... from a given string.

        public static string Test(string s, params int[] n)
        {
            string output = string.Empty;
            foreach(int i in n)
            {
                if(i < s.Length) output += s[i];
            }
            return output;
        }
    }
}

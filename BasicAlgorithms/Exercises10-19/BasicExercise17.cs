using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise17
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("Python", "yt", 1));
            Console.WriteLine(Test("ytade", "yt", 1));
            Console.WriteLine(Test("jsues", "yt", 1));
            Console.ReadLine();
        }

        //Write a C# Sharp program to check if a string 'yt' appears
        //at index 1 in a given string. If it appears return a string
        //without 'yt' otherwise return the original string. 

        public static string Test(string s, string compare, int index)
        {
            if (s[index..].StartsWith(compare))
            {
                return s.Remove(index, compare.Length - 1);
            }
            else return s;
        }
    }
}

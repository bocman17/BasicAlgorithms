using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise28
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("caabb", 'a'));
            Console.WriteLine(Test("babaaba", 'a'));
            Console.WriteLine(Test("aaaaa", 'a'));
            Console.ReadLine();
        }
        //Write a C# Sharp program to check if the first appearance of "a"
        //in a given string is immediately followed by another "a".

        public static bool Test
            (string s, char c)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    return s[i] == s[i + 1];
                }
            }
            return false;
        }
    }
}

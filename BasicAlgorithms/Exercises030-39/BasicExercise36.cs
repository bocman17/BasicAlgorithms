﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise36
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("xxHxix", 'x'));
            Console.WriteLine(Test("abxdddca", 'a'));
            Console.WriteLine(Test("xabjbhtbb", 'b'));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new string
        // from a give string where a specified character have
        // been removed except starting and ending position of the given string.

        public static string Test(string s, char c)
        {
            for (int i = 1; i < s.Length-1; i++)
            {
                if (s[i] == c) s = s.Remove(i, 1);
            }
            return s;
        }
    }
}

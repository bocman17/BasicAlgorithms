﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise31
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("abcdsab"));
            Console.WriteLine(Test("abcdabab"));
            Console.WriteLine(Test("abcabdabab"));
            Console.WriteLine(Test("abcabd"));
            Console.ReadLine();
        }
        //Write a C# Sharp program to count a substring of length
        //2 appears in a given string and also as the last 2
        //characters of the string. Do not count the end substring.

        public static int Test(string s, int n = 2)
        {
            int count = 0;
            var lastChars = s.Substring(s.Length - n);
            for (int i = 0; i < s.Length - n; i++)
            {
                if (s.Substring(i, n).Equals(lastChars)) count++;
            }
            return count;
        }
    }
}

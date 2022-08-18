using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise27
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("bbaaccaag", "aa"));
            Console.WriteLine(Test("jjkiaaasew", "ew"));
            Console.WriteLine(Test("JSaaakoiaa", "aa"));
            Console.WriteLine(Test2("jjkiaaasew", "aa"));
            Console.WriteLine(Test2("bbaaccaag", "aa"));
            Console.WriteLine(Test2("JSaaakoiaa", "aa"));
            Console.ReadLine();
        }
        //Write a C# Sharp program to count the string "aa" in a given string
        //and assume "aaa" contains two "aa".

        public static int Test(string s, string regex)
        {
            return Regex.Matches(s, regex).Count;
        }

        public static int Test2(string s, string regex)
        {
            int ctr_aa = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s.Substring(i, 2) == regex)
                {
                    ctr_aa++;
                }
            }
            return ctr_aa;
        }
    }
}

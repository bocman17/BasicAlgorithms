using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class Integer6
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountString("bbaaccaag", "aa"));
            Console.WriteLine(CountString("jjkiaaasew", "aa"));
            Console.WriteLine(CountString("JSaaakoiaa", "aa"));
            Console.WriteLine(test("jjkiaaasew", "aa"));
            Console.WriteLine(test("bbaaccaag", "aa"));
            Console.WriteLine(test("JSaaakoiaa", "aa"));
            Console.ReadLine();
        }
        //Write a C# Sharp program to count the string "aa" in a given string
        //and assume "aaa" contains two "aa".

        public static int CountString(string s, string regex)
        {
            return Regex.Matches(s, regex).Count;
        }

        public static int test(string s, string regex)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise84
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("abcab"));
            Console.WriteLine(Test("Python"));
            Console.WriteLine(Test("aaa"));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new string from a
        // given string. If the two characters of the given string
        // from its beginning and end are same return  the given string
        // without the first two characters otherwise return the original string.

        public static string Test(string str, int chars = 2)
        {
            if(str.Length <= chars) return str;
            else if (str[..chars] == str[^chars..]) return str[chars..];
            else return str;
        }
    }
}

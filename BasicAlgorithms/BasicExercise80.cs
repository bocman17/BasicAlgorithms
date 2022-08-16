using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise80
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("abc", new string[] { "abc", "xyz" }));
            Console.WriteLine(Test("abcdef", new string[] { "abc", "xyz" }));
            Console.WriteLine(Test("C", new string[] { "abc", "xyz" }));
            Console.WriteLine(Test("xyz", new string[] { "abc", "xyz" }));
            Console.WriteLine(Test("xyzef", new string[] { "abc", "xyz" }));
            Console.ReadLine();
        }
        // Write a C# Sharp program to check if a given string begins with 'abc' or 'xyz'.
        // If the string begins with 'abc' or 'xyz' return 'abc' or 'xyz' otherwise
        // return the empty string.

        public static string Test(string str, string[] strArr)
        {
            for (int i = 0; i < strArr.Length; i++)
            {
                if (str.StartsWith(strArr[i])) return strArr[i];
            }
            return string.Empty;
        }
    }
}

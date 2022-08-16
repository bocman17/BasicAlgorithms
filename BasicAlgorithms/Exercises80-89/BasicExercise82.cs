using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise82
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("abc", "abcd"));
            Console.WriteLine(Test("Python", "Python"));
            Console.WriteLine(Test("JS", "Python"));
            Console.WriteLine(Test(new string[] {"Tasjinka", "Tom", "Daniel"}));
            Console.WriteLine(Test(new string[] {"Tasjinecka", "PutlerDiesToday", "Dandulka", "Liberec"}));
            Console.ReadLine();
        }
        // Write a C# Sharp program to combine two given strings.
        // If the given strings have different length remove the
        // characters from the longer string. 

        public static string Test(string s1, string s2)
        {
            if (s1.Length == s2.Length) return s1 + s2;
            else if (s1.Length > s2.Length)
            {
                char[] arr = s1.Skip(s1.Length - s2.Length).ToArray();
                string output = String.Join("", arr);
                return output + s2;
            }
            else
            {
                char[] arr = s2.Skip(s2.Length - s1.Length).ToArray();
                string output = String.Join("", arr);
                return s1 + output;
            }

        }
        public static string Test(string[] strArr)
        {
            strArr = strArr.OrderBy(s => s.Length).ToArray();
            string output = strArr[0];
            for (int i = 1; i < strArr.Length; i++)
            {
                output += strArr[i][^strArr[0].Length..];
            }
            return output;
        }
    }
}

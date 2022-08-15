using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise79
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("abc"));
            Console.WriteLine(Test("Hello"));
            Console.WriteLine(Test("Python"));
            Console.WriteLine(Test("JS"));
            Console.WriteLine(Test("C"));
            Console.WriteLine(Test(new string[] {"Tasja", "Daniel", "Bocman", "", "a"}));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new string from a given
        // string after swapping last two characters.

        public static string Test(string str)
        {
            if (str.Length > 1)
                return str[..^2] + str[^1] + str[^2];
            else return str;
        }

        public static string Test(string[] strArr)
        {
            strArr = strArr.Where(s => s.Length > 1)
                .Select(s => s[..^2] + s[^1] + s[^2]).ToArray();

            string output = String.Join(", ", strArr);
            return output;
        }
    }
}

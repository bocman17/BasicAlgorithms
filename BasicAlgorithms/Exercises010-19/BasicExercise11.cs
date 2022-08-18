using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise11
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("Python"));
            Console.WriteLine(Test("JS"));
            Console.WriteLine(Test("Code"));
            Console.WriteLine(Test("1"));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new string taking the first 3
        // characters of a given string and return the string with the 3 characters
        // added at both the front and back. If the given string length is less than 3,
        // use whatever characters are there.

        public static string Test(string s, int count = 3)
        {
            if(count >= s.Length)
            {
                var builder = new StringBuilder(s.Length * 3);
                for (int i = 0; i < 3; i++) builder.Append(s);
                return builder.ToString();
            }
            string sub = s.Substring(0, count);
            return sub + s + sub;
        }
    }
}

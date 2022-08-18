using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise85
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("abcab"));
            Console.WriteLine(Test("python"));
            Console.WriteLine(Test("press"));
            Console.WriteLine(Test("jython"));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new string from a given
        // string without the first two characters. Keep the first character
        // if it is "p" and keep the second character if it is "y".

        public static string Test(string str, char a = 'p', char b = 'y')
        {
            string output = str[2..];
            if (str[1] == b)
            {
                output = str[1] + output;
            }
            if (str[0] == a)
            {
                output = str[0] + output;

            }
            return output;
        }
    }
}

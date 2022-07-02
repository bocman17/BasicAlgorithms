using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class String1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddString("if else"));
            Console.WriteLine(AddString("else"));
            Console.ReadLine();
        }

        // Write a C# Sharp program to create
        // a new string where 'if' is added to the front of a given string.
        // If the string already begins with 'if', return the string unchanged. 

        public static string AddString(string s, string param = "if")
        {
            return s.StartsWith("if") ? s : $"{param} {s}";
        }
    }
}

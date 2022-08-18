using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise77
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("Hello", "Hi"));
            Console.WriteLine(Test("Python", "PHP"));
            Console.WriteLine(Test("JS", "JS"));
            Console.WriteLine(Test("Csharp", ""));
            Console.WriteLine(Test("", ""));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new string taking the first
        // character from a given string and the last character from another
        // given string. If the length of any given string is 0, use '#' as
        // its missing character. 
            
        public static string Test(string s1, string s2, char ch = '#')
        {
            if (string.IsNullOrEmpty(s1)) s1 = char.ToString(ch);
            if (string.IsNullOrEmpty(s2)) s2 = char.ToString(ch);

            string output = s1[..1] + s2[..1];

            return output;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise6
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ChangeChar("Python", 1));
            Console.WriteLine(ChangeChar("Python", 0));
            Console.WriteLine(ChangeChar("Python", 4));
            Console.WriteLine(ChangeChar("Python", 7));
            Console.ReadLine();
        }
        //Write a C# Sharp program to remove the character
        //in a given position of a given string.
        //The given position will be in the range 0.. string length -1 inclusive.

        public static string ChangeChar(string s, int n)
        {
            //if (0 > n && n > s.Length - 1) return s;
            //else return s.Substring(0, n) + s.Substring(n+1);

            if (0 > n || n > s.Length - 1) return s;
            else return s.Remove(n, 1);
        }
    }
}

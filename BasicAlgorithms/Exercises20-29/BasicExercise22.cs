using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise22
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfStringContainsChars("frizz", 'z'));
            Console.WriteLine(CheckIfStringContainsChars("zane", 'z'));
            Console.WriteLine(CheckIfStringContainsChars("Zazz", 'z'));
            Console.WriteLine(CheckIfStringContainsChars("false", 'z'));
            Console.WriteLine(CheckIfStringContainsChars("zzzz", 'z'));
            Console.WriteLine(CheckIfStringContainsChars("ZZZZ", 'z'));
            Console.WriteLine(CheckIfStringContainsChars("zzzzz", 'z'));
            Console.WriteLine(CheckIfStringContainsChars("azazaz", 'z'));
            Console.ReadLine();
        }
        //Write a C# Sharp program to check if a given string contains
        //between 2 and 4 'z' character.

        public static bool CheckIfStringContainsChars
            (string str, char letter, int min = 2, int max = 4)
        {
            int count =  str.Where(c => c == letter).Count();
            return count >= min && count <= max;
        }
    }
}

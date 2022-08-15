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
            Console.WriteLine(Test("frizz", 'z'));
            Console.WriteLine(Test("zane", 'z'));
            Console.WriteLine(Test("Zazz", 'z'));
            Console.WriteLine(Test("false", 'z'));
            Console.WriteLine(Test("zzzz", 'z'));
            Console.WriteLine(Test("ZZZZ", 'z'));
            Console.WriteLine(Test("zzzzz", 'z'));
            Console.WriteLine(Test("azazaz", 'z'));
            Console.ReadLine();
        }
        //Write a C# Sharp program to check if a given string contains
        //between 2 and 4 'z' character.

        public static bool Test
            (string str, char letter, int min = 2, int max = 4)
        {
            int count =  str.Where(c => c == letter).Count();
            return count >= min && count <= max;
        }
    }
}

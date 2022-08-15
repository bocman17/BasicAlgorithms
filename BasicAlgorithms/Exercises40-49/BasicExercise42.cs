using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise42
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(13));
            Console.WriteLine(Test(14));
            Console.WriteLine(Test(27));
            Console.WriteLine(Test(12));
            Console.ReadLine();
        }
        // Write a C# Sharp program to test if a given non-negative number is
        // a multiple of 13 or it is one more than a multiple of 13.

        public static bool Test(int x, int n = 13)
        {
            return x % n == 0 || x % n == 1;
        }
    }
}

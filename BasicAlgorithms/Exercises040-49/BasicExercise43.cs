using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise43
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(3));
            Console.WriteLine(Test(7));
            Console.WriteLine(Test(8));
            Console.WriteLine(Test(21));
            Console.ReadLine();
        }
        // Write a C# Sharp program to check if a given non-negative
        // given number is a multiple of 3 or 7, but not both.

        public static bool Test(int x, int y = 3, int z = 7)
        {
            return x % y == 0 ^ x % z == 0;
        }
    }
}

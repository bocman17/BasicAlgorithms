using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class Bool19
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfXisMultiOfYorZbutNotBoth(3));
            Console.WriteLine(CheckIfXisMultiOfYorZbutNotBoth(7));
            Console.WriteLine(CheckIfXisMultiOfYorZbutNotBoth(8));
            Console.WriteLine(CheckIfXisMultiOfYorZbutNotBoth(21));
            Console.ReadLine();
        }
        // Write a C# Sharp program to check if a given non-negative
        // given number is a multiple of 3 or 7, but not both.

        public static bool CheckIfXisMultiOfYorZbutNotBoth(int x, int y = 3, int z = 7)
        {
            return x % y == 0 ^ x % z == 0;
        }
    }
}

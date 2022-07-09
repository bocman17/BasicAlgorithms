using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class Bool21
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfXaddYisZ(1, 2, 3));
            Console.WriteLine(CheckIfXaddYisZ(4, 5, 6));
            Console.WriteLine(CheckIfXaddYisZ(-1, 1, 0));
            Console.WriteLine(test(-1, 1, 0));
            Console.WriteLine(test(4, 5, 6)); ;
            Console.WriteLine(test(1,2,3));
            Console.WriteLine(test(5,2,3,8,9,27));
            Console.ReadLine();
        }
        // Write a C# Sharp program to check if it is
        // possible to add two integers to get the third integer from three given integers.

        public static bool CheckIfXaddYisZ(int x, int y, int z)
        {
            return x + y == z;
        }

        public static bool test(params int[] n)
        {
            return n.Take(n.Length - 1).Sum() == n[^1];
        }
    }
}

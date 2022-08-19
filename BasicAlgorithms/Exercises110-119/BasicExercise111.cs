using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise111
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", Test(new[] { 1, 5, 7, 9, 10, 17 })));
            Console.WriteLine(String.Join(" ", Test(new[] { 1, 5, 7, 9, 10, 12 })));
            Console.WriteLine(String.Join(" ", Test(new[] { 17 })));
            Console.WriteLine(String.Join(" ", Test(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })));
            Console.WriteLine(String.Join(" ", Test(new[] { 1, 2, 2, 3, 7, 8, 9, 10, 6, 5, 4 })));
            Console.WriteLine(String.Join(" ", Test(new[] { 1, 2, 3, 4, 5, 6, 7, 8 })));
            Console.ReadLine();
        }
        // Write a C# Sharp program to compute the sum of values in a given array of
        // integers except the number 17. Return 0 if the given array has no integer.

        public static int Test(int[] nums, int except = 17)
        {
            return nums.Where(x => x != except).Sum();
        }
    }
}

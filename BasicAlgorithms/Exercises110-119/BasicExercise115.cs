using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise115
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 1, 5, 6, 9, 10, 17 }));
            Console.WriteLine(Test(new[] { 1, 5, 5, 5, 10, 17 }));
            Console.WriteLine(Test(new[] { 1, 1, 5, 5, 5, 5 }, 1, 2));
            Console.WriteLine(Test(new[] { 1, 5, 9, 10, 17, 5, 6 }));
            Console.WriteLine(Test(new[] { 1, 5, 9, 10, 17, 5 }));
            Console.WriteLine(Test(new[] { 6, 5, 6 }));
            Console.WriteLine(Test(new[] { 5,5,6 }));
            Console.WriteLine(Test(new[] { 6,6,5 }));

            Console.ReadLine();
        }
        // Write a C# Sharp program to check if the sum of all 5' in the array
        // exactly 15 in a given array of integers.

        public static bool Test(int[] nums, int n = 5, int sum = 15)
        {
            return nums.Where(x => x == n).Sum() == sum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise107
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", Test(new[] { 1, 2, 3, 4 })));
            Console.WriteLine(String.Join(" ", Test(new[] { 1 })));
            Console.WriteLine(String.Join(" ", Test(new[] { 1, 2, 9, 3, 3 })));
            Console.WriteLine(String.Join(" ", Test(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })));
            Console.WriteLine(String.Join(" ", Test(new[] { 1, 2, 2, 3, 7, 8, 9, 10, 6, 5, 4 })));
            Console.WriteLine(String.Join(" ", Test(new[] { 1, 2, 3, 4, 5, 6, 7, 8 })));
            Console.ReadLine();
        }
        // Write a C# Sharp program to find the largest value from first, last,
        // and middle elements of a given array of integers of odd length (at least 1).

        public static int Test(int[] nums)
        {
            int[] temp = { nums.First(), nums[nums.Length / 2], nums.Last() };
            return temp.Max();
        }
    }
}

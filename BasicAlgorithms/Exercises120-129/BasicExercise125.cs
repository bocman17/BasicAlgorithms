using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise125
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 3, 7, 5, 5, 3, 7 }, 2));
            Console.WriteLine(Test(new[] { 3, 7, 5, 5, 3, 7 }, 3));
            Console.WriteLine(Test(new[] { 3, 7, 5, 5, 3, 7, 5 }, 3));
            Console.ReadLine();
        }
        // Write a C# Sharp program to check a given array of integers and
        // return true if the specified number of same elements appears at
        // the start and end of the given array.

        public static bool Test(int[] nums, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (nums[i] == nums[nums.Length - n + i]) return true;
            }
            return false;
        }
    }
}

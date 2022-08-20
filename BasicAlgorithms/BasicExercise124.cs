using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise124
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 3, 5, 5, 3, 7 }));
            Console.WriteLine(Test(new[] { 3, 5, 5, 4, 1, 5, 7 }));
            Console.WriteLine(Test(new[] { 3, 5, 5, 5, 5, 5 }));
            Console.WriteLine(Test(new[] { 2, 4, 5, 5, 6, 7, 5 }));
            Console.ReadLine();
        }
        // Write a C# Sharp program to check a given array of integers and return
        // true if every 5 that appears in the given array is next to another 5.

        public static bool Test(int[] nums, int n = 5)
        {
            if (nums.First() == n && nums[1] != n) return false;
            else if (nums.Last() == n && nums[^2] != n) return false;
            else
            {
                for (int i = 1; i < nums.Length - 1; i++)
                {
                    if (nums[i] == n && nums[i + 1] != n && nums[i - 1] != n) return false;
                }
            }
            return true;
        }
    }
}

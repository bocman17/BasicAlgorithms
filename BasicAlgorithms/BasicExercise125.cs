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
            Console.ReadLine();
        }
        // Write a C# Sharp program to check a given array of integers and
        // return true if the specified number of same elements appears at
        // the start and end of the given array.

        public static bool Test(int[] nums, int n)
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

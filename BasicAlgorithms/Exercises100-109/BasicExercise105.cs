using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise105
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", Test(new[] { 1, 2, 3 })));
            Console.WriteLine(String.Join(" ", Test(new[] { 1 })));
            Console.WriteLine(String.Join(" ", Test(new[] { 24,986,898,151,98798,3,98 })));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new array swapping the first
        // and last elements of a given array of integers and length will be least 1.

        public static int[] Test(int[] nums)
        {
            if (nums.Length <= 1) return nums;
            else
            {
                int temp = nums.First();
                nums.SetValue(nums.Last(), 0);
                nums.SetValue(temp, nums.Length - 1);
                return nums;
            }
        }
    }
}

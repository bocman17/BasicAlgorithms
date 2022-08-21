using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise126
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 1, 2, 3, 5, 3, 7 }));
            Console.WriteLine(Test(new[] { 3, 7, 5, 5, 3, 7 }));
            Console.WriteLine(Test(new[] { 3, 7, 5, 5, 6, 7, 5 }));
            Console.ReadLine();
        }
        // Write a C# Sharp program to check a given array of integers and return
        // true if the array contains three increasing adjacent numbers.

        public static bool Test(int[] nums)
        {
            //for (int i = 0; i < nums.Length - 2; i++)
            //{
            //    if (nums[i] == nums[i + 1] - 1 && nums[i] == nums[i + 2] - 2) return true;
            //}
            //return false;

            return nums.Zip(nums.Skip(1), (a, b) => (a + 1) == b).Any();
        }
    }
}

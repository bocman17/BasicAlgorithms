using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise100
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 20, 20 }));
            Console.WriteLine(Test(new[] { 10, 10 }));
            Console.WriteLine(Test(new[] { 12, 20 }));
            Console.WriteLine(Test(new[] { 10 }));
            Console.WriteLine(Test(new[] { 1,2,3,4,4,5,6,7,8,9 }, new[] { 1,2,3}));
            Console.WriteLine(Test(new[] { 2,2,4,6,8,4}, new[] {10,12,4}));
            Console.ReadLine();
        }
        // Write a C# Sharp program to check a given array of integers and
        // return true if the array contains 10 or 20 twice. The length of
        // the array will be 0, 1, or 2.

        public static bool Test(int[] nums, int a = 10, int b = 20, int target = 2)
        {
            int countA = 0;
            int countB = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == a) countA++;
                if (nums[i] == b) countB++;

                if (countA == target || countB == target) return true;
            }
            return false;
        }

        public static bool Test(int[] nums, int[] arr, int target = 2)
        {
            if(nums.Intersect(arr).Any())
            {
                int[] temp = nums.GroupBy(x => x).Where(g => g.Count() == target)
                            .Select(y => y.Key).ToArray();
                return arr.Intersect(temp).Any();
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise102
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 10, 20, -30 }, new[] { 10, 20, 30 }));
            Console.WriteLine(Test(new[] { 10, 20, 31 }, new[] { 10, 22, 29 }));
            Console.WriteLine(Test(new[] { 1,2,3,4,5,6,7 }, new[] { 100 }));
            Console.ReadLine();
        }
        // Write a C# Sharp program to compute the sum of the two given arrays
        // of integers, length 3 and find the array which has the largest sum.

        public static string Test(int[] nums1, int[] nums2)
        {
            if (nums1.Sum() == nums2.Sum())
                return $"Both array has same sum, arr1: {String.Join(" ", nums1)}, arr2: " +
                    $"{String.Join(" ", nums2)} with sum of: {nums1.Sum()}";
            int[] output = nums1.Sum() > nums2.Sum() ? nums1 : nums2;
            return $"Larger array: {String.Join(" ", output)}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise104
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", Test(new[] {1,2,3}, new[] {4,5,6})));
            Console.WriteLine(String.Join(" ", Test(new[] { 10, 20, 30 }, new[] { 40, 50, 60 })));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new array from two give array of
        // integers, each length 3.

        public static int[] Test(int[] nums1, int[] nums2)
        {
            return nums1.Concat(nums2).ToArray();
        }
    }
}

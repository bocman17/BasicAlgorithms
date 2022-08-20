using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise129
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 10, 20, -30, -40, 50 }));
            Console.WriteLine(Test(new[] { 1, 2, 3, 5, 7 }));
            Console.WriteLine(Test(new[] { 3, 7, 5, 5, 6, 7, 5 }));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new array taking the elements after
        // the element value 5 from a given array of integers.

        public static string Test(int[] nums, int k = 5)
        {
            int index = Array.IndexOf(nums, k);
            if (index == -1) return String.Join(" ", nums);
            else
            {
                int[] arr = nums.Take(index).ToArray();
                return String.Join(" ", arr);
            }
        }
    }
}

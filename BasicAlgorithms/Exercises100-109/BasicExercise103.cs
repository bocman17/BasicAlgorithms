using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise103
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 10, 20, -30 }));
            Console.WriteLine(Test(new[] { 10, 20, -30, 40 }));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create an array taking two middle
        // elements from a given array of integers of length even.

        public static string Test(int[] nums)
        {
            if(nums.Length % 2 == 0)
            {
                int[] arr = new int[2];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = nums[nums.Length / 2 - i];
                }
                return $"Original array: {String.Join(" ", nums)}\n" +
                    $"Middle Array: {String.Join(" ", arr.Reverse())}";
            }
            else
            {
                int middle = nums[nums.Length / 2];
                return $"Original array: {String.Join(" ", nums)}\n" +
                    $"Middle: {middle}";
            }
        }
    }
}

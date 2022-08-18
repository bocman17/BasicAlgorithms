using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise99
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 12, 20 }));
            Console.WriteLine(Test(new[] { 14, 15 }));
            Console.WriteLine(Test(new[] { 11, 21 }));
            Console.WriteLine(Test(new[] { 10, 20, -30, -40, 30 }));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new array of integers and length 1 or more.
        // The length of the new array will be double length of the given array and all the
        // elements are 1 except the first element which is equal to the given array. 

        public static string Test(int[] arr)
        {
            int[] nums = new int[arr.Length * 2];
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0) nums[i] = arr[i];
                else nums[i] = 0;
            }

            return String.Join(" ", nums);
        }
    }
}

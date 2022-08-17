using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise95
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 10, 20, -30, -40, 30 }, new[] { 10, 20, 30, 40, 30 }));
            Console.WriteLine(Test(new[] { 1,2,3 }, new[] { 4,5,6 }));
            Console.WriteLine(Test(new[] { 2,4,6,8 }, new[] { 12,14,16,18 }));
            Console.WriteLine(Test(new[] { 2,4,6,8 }, new[] { 12,14,16 }));
            Console.WriteLine(Test(new[] { 2,4,6 }, new[] { 12,14,16,18 }));
            Console.ReadLine();
        }
        //  Write a C# Sharp program to create a new array containing
        //  the middle elements from the two given arrays of integers, each length 5.

        public static string Test(int[] arr1, int[] arr2)
        {
            if(arr1.Length % 2 == 0 && arr2.Length % 2 == 0)
            {
                int[] nums = new int[4];
                nums[0] = (int)arr1.GetValue(arr1.Length / 2 - 1);
                nums[1] = (int)arr1.GetValue(arr1.Length / 2);
                nums[2] = (int)arr2.GetValue(arr2.Length / 2 - 1);
                nums[3] = (int)arr2.GetValue(arr2.Length / 2);
                return String.Join(" ", nums);
            }
            else if(arr1.Length % 2 == 0) 
            {
                int[] nums = new int[3];
                nums[0] = (int)arr1.GetValue(arr1.Length / 2 - 1);
                nums[1] = (int)arr1.GetValue(arr1.Length / 2);
                nums[2] = (int)arr2.GetValue(arr2.Length / 2);
                return String.Join(" ", nums);
            }
            else if (arr2.Length % 2 == 0)
            {
                int[] nums = new int[3];
                nums[0] = (int)arr1.GetValue(arr1.Length / 2);
                nums[1] = (int)arr2.GetValue(arr2.Length / 2 - 1);
                nums[2] = (int)arr2.GetValue(arr2.Length / 2);
                return String.Join(" ", nums);
            }
            else
            {
                int[] nums = new int[2];

                nums[0] = (int)arr1.GetValue(arr1.Length / 2);
                nums[1] = (int)arr2.GetValue(arr2.Length / 2);
                return String.Join(" ", nums);
            }
        }

    }
}

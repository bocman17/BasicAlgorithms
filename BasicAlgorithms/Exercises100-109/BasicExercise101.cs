using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise101
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 1, 5, 7 }));
            Console.WriteLine(Test(new[] { 1, 25, 7, 4, 7, 5 }));
            Console.WriteLine(Test(new[] { 10, 10, 30, 40 }));
            Console.WriteLine(Test(new[] { 12, 20 }));
            Console.WriteLine(Test(new[] { 10 }));
            Console.ReadLine();
        }
        // Write a C# Sharp program to check a given array of integers,
        // length 3 and create a new array. If there is a 5 in the given
        // array immediately followed by a 7 then set 7 to 1. 

        public static string Test(int[] nums, int a = 5, int b = 7, int c = 1)
        {
            int[] seq = { a, b };
            bool sequenceFound = false;
            for (int i = 0; i <= nums.Length - seq.Length; i++)
            {
                if (nums.Skip(i).Take(seq.Length).SequenceEqual(seq))
                {
                    sequenceFound = true;
                    break;
                }
            }
            if(sequenceFound)
            {
                int[] arr = new int[nums.Length];
                Array.Copy(nums, arr, nums.Length);
                arr.SetValue(c, Array.IndexOf(nums, b));
                return $"Original array:  {String.Join(" ", nums)}\nNew array: {String.Join(" ", arr)}";
            }

            return $"Original array: {String.Join(" ", nums)}";

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i].Equals(a) && nums[i+1].Equals(b))
            //    {
            //        nums[i+1] = c;
            //    }
            //}
        }
    }
}

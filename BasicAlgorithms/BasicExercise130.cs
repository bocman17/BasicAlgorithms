using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise130
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 1, 2, 0, 3, 5, 7, 0, 9, 11 }, 5));
            Console.WriteLine(Test(new[] { 1, 0, 3, 4, 0 }));
            Console.WriteLine(Test(new[] { 0,0,2,0,3 }));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new array from a given array
        // of integers shifting all zeros to left direction.

        static string Test(int[] nums, int n = 0)
        {
            int indexLength = nums.Length - 1;
            int lastNonN = 0;

            for (int i = indexLength; i >= 0; i--)
            {
                if (lastNonN == 0) lastNonN = i;
                if (nums[i] != n) nums[lastNonN--] = nums[i];
            }

            while (lastNonN >= 0) nums[lastNonN--] = n;

            return String.Join(" ", nums);
        }
    }
}

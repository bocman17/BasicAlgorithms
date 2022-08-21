using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise135
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 1, 2, 3, 4, 6, 8 }));
            Console.WriteLine(Test(new[] { 15, 2, 3, 4, 15, 11 }));
            Console.WriteLine(Test(new[] { 3, 3, 15, 15, 5, 5 }));
            Console.WriteLine(Test(new[] { 1, 5, 15, 7, 8, 15 }));
            Console.ReadLine();
        }
        // Write a C# Sharp program to find the larger average value between the
        // first and the second half of a given array of integers and minimum length
        // is at least 2. Assume that the second half begins at index (array length)/2.
        static int Test(int[] nums)
        {
            int countFirstHalf = 0;
            int countSecondHalf = 0;
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                if (i < n / 2) countFirstHalf += nums[i];
                else countSecondHalf += nums[i];
            }
            countFirstHalf /= (n / 2);
            countSecondHalf /= (n / 2);
            return countFirstHalf >= countSecondHalf ? countFirstHalf : countSecondHalf;
        }
    }
}

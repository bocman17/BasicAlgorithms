using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise133
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 5, 5, 1, 5, 5 }));
            Console.WriteLine(Test(new[] { 1, 2, 3, 4 }));
            Console.WriteLine(Test(new[] { 3, 3, 5, 5, 5, 5 }));
            Console.WriteLine(Test(new[] { 1, 5, 5, 7, 8, 4 }));
            Console.ReadLine();
        }
        // Write a C# Sharp program to check if the value of each element is equal
        // or greater than the value of previous element of a given array of integers.
        static bool Test(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1]) return false;
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise134
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 5, 5, 1, 15, 15 }));
            Console.WriteLine(Test(new[] { 15, 2, 3, 4, 15 }));
            Console.WriteLine(Test(new[] { 3, 3, 15, 15, 5, 5 }));
            Console.WriteLine(Test(new[] { 1, 5, 15, 7, 8, 15 }));
            Console.ReadLine();
        }
        // Write a C# Sharp program to check a given array (length will be at least 2)
        // of integers and return true if there are two values 15, 15 next to each other.
        static bool Test(int[] nums, int n = 15)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == n && nums[i + 1] == n) return true;
            }
            return false;
        }
    }
}

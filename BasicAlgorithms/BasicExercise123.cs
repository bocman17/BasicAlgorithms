using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise123
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 3, 5, 1, 5, 3, 5, 7, 5, 1, 5 }));
            Console.WriteLine(Test(new[] { 3, 5, 5, 5, 5, 5, 6}));
            Console.WriteLine(Test(new[] { 3, 5, 2, 5, 4, 5, 7, 5, 8, 5 }));
            Console.WriteLine(Test(new[] { 2, 4, 5 }));
            Console.ReadLine();
        }
        // Write a C# Sharp program to check a given array of integers and
        // return true if the value 5 appears 5 times and there are no 5 next
        // to each other. 

        public static bool Test(int[] nums, int n = 5, int k = 5)
        {
            var count = nums.Count(num => num == n);
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == n && nums[i+1] == n)
                {
                    return false;
                }
            }
            if(count == k) return true;
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise132
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 1, 2, 0, 3, 5, 7, 0, 9, 11 }));
            Console.WriteLine(Test(new[] { 1, 2, 3, 4, 0 }));
            Console.WriteLine(Test(new[] { 0,0,2,0,3 }));
            Console.WriteLine(Test(new[] { 1, 2, 5, 3, 5, 7, 5, 9, 11 }));   
            Console.ReadLine();
        }
        // Write a C# Sharp program to create new array from a given array
        // of integers shifting all even numbers before all odd numbers.
        static string Test(int[] nums)
        {
            int indexLength = nums.Length - 1;
            int lastNonEven = 0;

            for (int i = indexLength; i >= 0; i--)
            {
                if (lastNonEven == 0) lastNonEven = i;
                if (nums[i] % 2 != 0) nums[lastNonEven--] = nums[i];
            }

            while (lastNonEven >= 0) nums[lastNonEven--] = 0;

            return String.Join(" ", nums);
        }
    }
}

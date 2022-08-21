using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise131
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 1, 2, 0, 3, 5, 7, 0, 9, 11 }));
            Console.WriteLine(Test(new[] { 1, 2, 3, 4, 0 }));
            Console.WriteLine(Test(new[] { 0,0,2,0,3 }));
            Console.WriteLine(Test(new[] { 1, 2, 5, 3, 5, 7, 5, 9, 11 }));   
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new array after replacing all
        // the values 5 with 0 shifting all zeros to right direction.
        static string Test(int[] nums, int change = 5, int changeTo = 0)
        {
            int indexLength = nums.Length;
            if (indexLength <= 0) return "0";
            int lastNonZero = 0;

            for (int i = 0 ; i < indexLength; i++)
            {
                if (nums[i] == change) nums[i] = changeTo;
                if (nums[i] != changeTo) nums[lastNonZero++] = nums[i];
            }
            while (lastNonZero < indexLength) nums[lastNonZero++] = changeTo;

            return String.Join(" ", nums);
        }
    }
}

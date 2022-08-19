using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise112
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 5, 6, 1, 5, 6, 9, 10, 17, 5, 6 }));
            Console.WriteLine(Test(new[] { 5, 6, 1, 5, 6, 9, 10, 17 }));
            Console.WriteLine(Test(new[] { 1, 5, 6, 9, 10, 17, 5, 6 }));
            Console.WriteLine(Test(new[] { 1, 5, 9, 10, 17, 5, 6 }));
            Console.WriteLine(Test(new[] { 1, 5, 9, 10, 17, 5 }, 1, 5));
            Console.WriteLine(Test(new[] { 6, 5, 6 }));
            Console.WriteLine(Test(new[] { 5,5,6 }));
            Console.WriteLine(Test(new[] { 6,6,5 }));

            Console.ReadLine();
        }
        // Write a C# Sharp program to compute the sum of the numbers in a given
        // array except those numbers starting with 5 followed by at least one 6.
        // Return 0 if the given array has no integer. 

        public static int Test(int[] nums, int except = 5, int followed = 6)
        {
            int sum = 0;
            int[] sequence = { except, followed };
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0 && nums[i] == followed) sum += nums[i];
                else if (nums.Skip(i).Take(sequence.Length).SequenceEqual(sequence) ||
                    nums[i] == followed && nums[i - 1] == except) continue;
                else sum += nums[i];
            }
            return sum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise113
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 1, 5, 6, 9, 10, 17 }));
            Console.WriteLine(Test(new[] { 1, 5, 5, 9, 10, 17 }));
            Console.WriteLine(Test(new[] { 1, 5, 9, 10, 17, 5, 5 }));
            Console.WriteLine(Test(new[] { 1, 5, 9, 10, 17, 5, 6 }));
            Console.WriteLine(Test(new[] { 1, 5, 9, 10, 17, 5 }));
            Console.WriteLine(Test(new[] { 6, 5, 6 }));
            Console.WriteLine(Test(new[] { 5,5,6 }));
            Console.WriteLine(Test(new[] { 6,6,5 }));

            Console.ReadLine();
        }
        // Write a C# Sharp program to check if a given array of integers
        // contains 5 next to a 5 somewhere.

        public static bool Test(int[] nums, int check = 5)
        {
            int[] sequence = { check, check };
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums.Skip(i).Take(sequence.Length).SequenceEqual(sequence)) return true;
            }
            return false;
        }
    }
}

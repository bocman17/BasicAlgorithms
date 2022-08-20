using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise120
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 5, 5, 5, 5, 5 }));
            Console.WriteLine(Test(new[] { 1,5,1,5 }));
            Console.WriteLine(Test(new[] { 3, 3, 3, 5, 5 }));
            Console.WriteLine(Test(new[] { 1, 5, 5, 7, 8, 10 }));
            Console.WriteLine(Test(new[] { 1, 5, 9, 10, 17, 5 }));
            Console.WriteLine(Test(new[] { 1,2,3,4 }));
            Console.WriteLine(Test(new[] { 5,3,5,3 }));
            Console.WriteLine(Test(new[] { 1, 5, 5, 7, 8, 10 }));

            Console.ReadLine();
        }
        // Write a C# Sharp program to check a given array of integers and return true
        // if the given array contains two 5's next to each other, or two 5 separated
        // by one element.

        public static bool Test(int[] nums, int a = 5)
        {
            int[] seq1 = { a, a };

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums.Skip(i).Take(seq1.Length).SequenceEqual(seq1)) return true;
                else if (i + 2 < nums.Length && nums[i] == a && nums[i + 2] == a) return true;
            }
            return false;
        }
    }
}

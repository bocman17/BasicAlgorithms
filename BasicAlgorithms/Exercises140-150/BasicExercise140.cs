using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise140
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", Test(new[] { 1, 2, 3, 5, 7, 9, 10 }, 1)));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new array of given length using the
        // odd numbers from a given array of positive integers.
        static int[] Test(int[] nums, int n)
        {
            return nums.Where(num => num % 2 == 1).Take(n).ToArray();
        }
    }
}

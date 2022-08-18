using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise108
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", Test(new[] { 1, 2, 3, 4 })));
            Console.WriteLine(String.Join(" ", Test(new[] { 1 })));
            Console.WriteLine(String.Join(" ", Test(new[] { 1, 5, 7, 9, 11, 13 })));
            Console.WriteLine(String.Join(" ", Test(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })));
            Console.WriteLine(String.Join(" ", Test(new[] { 1, 2, 2, 3, 7, 8, 9, 10, 6, 5, 4 })));
            Console.WriteLine(String.Join(" ", Test(new[] { 1, 2, 3, 4, 5, 6, 7, 8 })));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new array taking the first two elements
        // from a given array. If the length of the given array is less than 2 then
        // return the give array.

        public static int[] Test(int[] nums)
        {
            return nums.Take(2).ToArray();
        }
    }
}

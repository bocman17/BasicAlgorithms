using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise118
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 5, 5, 5, 5, 5 }));
            Console.WriteLine(Test(new[] { 3, 3, 3, 3 }));
            Console.WriteLine(Test(new[] { 3, 3, 3, 5, 5, 5 }));
            Console.WriteLine(Test(new[] { 1, 6, 8, 10 }));
            Console.WriteLine(Test(new[] { 1, 5, 9, 10, 17, 5 }));
            Console.WriteLine(Test(new[] { 6, 5, 6 }));
            Console.WriteLine(Test(new[] { 5,3,6 }));
            Console.WriteLine(Test(new[] { 6,6,3 }));

            Console.ReadLine();
        }
        // Write a C# Sharp program to check if a given array of integers contains
        // no 3 or a 5.

        public static bool Test(int[] nums, int a = 5, int b = 3)
        {
            return !nums.Contains(a) || !nums.Contains(b);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise97
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 12, 20 }));
            Console.WriteLine(Test(new[] { 14, 15 }));
            Console.WriteLine(Test(new[] { 11, 21 }));
            Console.WriteLine(Test(new[] { 1,2,3,4,5,6,7,8,9,10}, new[] {100,90,80,70,60,50,10}));
            Console.WriteLine(Test(new[] { 1,2,3,4,5,6,7,8,9,10}, new[] {100,90, 80,70,60,50}));
            Console.ReadLine();
        }
        //  Write a C# Sharp program to check if a given array of integers
        //  and length 2, contains 15 or 20.

        public static bool Test(int[] arr, int x = 15, int y = 20)
        {
            return arr.Contains(x) || arr.Contains(y);
        }
        public static bool Test(int[] arr, int[] nums)
        {
            return arr.Intersect(nums).Any();
        }
    }
}

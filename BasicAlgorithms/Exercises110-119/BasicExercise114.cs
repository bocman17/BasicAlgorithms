using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise114
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 1, 5, 6, 9, 10, 17 }, new[] { 5,7}));
            Console.WriteLine(Test(new[] { 1, 4, 7, 9, 10, 17 }, new[] { 5, 8 }));
            Console.WriteLine(Test(new[] { 1, 1, 2, 9, 10, 17 }, new[] { 3, 7 }));
            Console.WriteLine(Test(new[] { 1, 5, 9, 10, 17, 5, 6 }));
            Console.WriteLine(Test(new[] { 1, 5, 9, 10, 17, 5 }));
            Console.WriteLine(Test(new[] { 6, 5, 6 }));
            Console.WriteLine(Test(new[] { 5,5,6 }));
            Console.WriteLine(Test(new[] { 6,6,5 }));

            Console.ReadLine();
        }
        // Write a C# Sharp program to check whether a given array of integers
        // contains 5's and 7's.

        public static bool Test(int[] nums, int checkA = 5, int checkB = 7)
        {
            return nums.Contains(checkA) || nums.Contains(checkB);
        }

        public static bool Test(int[] nums, int[] intersects)
        {
            IEnumerable<int> both = nums.Intersect(intersects);
            if(both.Any()) return true;
            return false;
        }
    }
}

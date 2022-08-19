using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise116
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 1, 5, 6, 9, 3, 3 }));
            Console.WriteLine(Test(new[] { 1, 5, 5, 5, 10, 17 }));
            Console.WriteLine(Test(new[] { 1, 3, 3, 5, 5, 5 }));
            Console.WriteLine(Test(new[] { 1, 5, 9, 10, 17, 5, 6 }));
            Console.WriteLine(Test(new[] { 1, 5, 9, 10, 17, 5 }));
            Console.WriteLine(Test(new[] { 6, 5, 6 }));
            Console.WriteLine(Test(new[] { 5,3,6 }));
            Console.WriteLine(Test(new[] { 6,6,3 }));

            Console.ReadLine();
        }
        // Write a C# Sharp program to check if the number of 3's is greater than the
        // number of 5's.

        public static bool Test(int[] nums, int a = 5, int b = 3)
        {
            return nums.Where(x => x == a).Count() <= nums.Where(x => x == b).Count();
        }
    }
}

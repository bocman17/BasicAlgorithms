using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise122
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 3, 5, 1, 3, 7 }));
            Console.WriteLine(Test(new[] { 1,2,3,4 }));
            Console.WriteLine(Test(new[] { 3, 3, 3, 5, 5 }));
            Console.WriteLine(Test(new[] { 2, 4, 5, 6 }));
            Console.WriteLine(Test(new[] { 5,2,55,2 }));
            Console.WriteLine(Test(new[] { 1,2,3,4,5,3 }));
            Console.ReadLine();
        }
        // Write a C# Sharp program to check a given array of integers and
        // return true if the given array contains either 2 even or 2 odd
        // values all next to each other.

        public static bool Test(int[] nums)
        {
            
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if ((nums[i] % 2 == 0 && nums[i + 1] % 2 == 0) ||
                    (nums[i] % 2 != 0 && nums[i + 1] % 2 != 0)) return true;
            }
            return false;
        }
    }
}

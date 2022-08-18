using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise96
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 10, 20, -30, -40, 30 }));
            Console.ReadLine();
        }
        //  Write a C# Sharp program to create a new array taking
        //  the first and last elements of a given array of integers and length 1 or more.

        public static string Test(int[] arr)
        {
            int[] nums = new int[2];

            nums[0] = arr.First();
            nums[1] = arr.Last();

            return String.Join(" ", nums);
        }

    }
}

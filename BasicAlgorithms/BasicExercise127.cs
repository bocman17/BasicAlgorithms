using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise127
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 10, 20, -30, -40, 50 }));
            Console.WriteLine(Test(new[] { 3, 7, 5, 5, 3, 7 }));
            Console.WriteLine(Test(new[] { 3, 7, 5, 5, 6, 7, 5 }));
            Console.ReadLine();
        }
        // Write a C# Sharp program to shift an element in left direction and
        // return a new array.

        public static string Test(int[] nums, int k = 1)
        {
            int n = nums.Length;
            int[] temp = new int[n];
            for (int i = 0; i < n - k; i++)
            {
                temp[i] = nums[i + k];
            }

            for (int i = 0; i < k; i++)
            {
                temp[n - i - 1] = nums[k - i - 1];
            }

            string output = String.Join(", ", temp);
            return output;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise132
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 1, 2, 5, 3, 5, 4, 9, 11, 6 }));
            Console.WriteLine(Test(new[] { 1, 2, 3, 4, 0 }));
            Console.WriteLine(Test(new[] { 0, 0, 2, 0, 3 }));
            Console.WriteLine(Test(new[] { 1, 2, 5, 3, 5, 7, 5, 9, 11 }));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create new array from a given array
        // of integers shifting all even numbers before all odd numbers.
        static string Test(int[] nums)
        {
            int i = 0, j = nums.Length - 1;

            while (j >= i)
            {
                if (nums[i] % 2 != 0)
                {
                    if (nums[j] % 2 == 0)
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                        i++;
                        j--;
                    }
                    else j--;
                }
                else i++;
            }
            return String.Join(" ", nums);
        }
    }
}

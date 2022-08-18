using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise106
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", Test(new[] { 1, 2, 3, 4 })));
            Console.WriteLine(String.Join(" ", Test(new[] { 1 })));
            Console.WriteLine(String.Join(" ", Test(new[] { 1, 2, 3 })));
            Console.WriteLine(String.Join(" ", Test(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })));
            Console.WriteLine(String.Join(" ", Test(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9,10,11 })));
            Console.WriteLine(String.Join(" ", Test(new[] { 1, 2, 3, 4, 5, 6, 7, 8 })));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new array length 3 from a given array
        // (length at least 3) using the elements from the middle of the array. 

        public static int[] Test(int[] nums, int k = 4)
        {

            if (nums.Length <= k) return nums;
            else if (k % 2 == 1)
            {
                if (nums.Length % 2 == 0)
                {
                    int[] result = nums.Skip((nums.Length - ++k) / 2).Take(k).ToArray();
                    return result;
                }
                else
                {
                    int[] result = nums.Skip((nums.Length - k) / 2).Take(k).ToArray();
                    return result;
                }
            }
            else
            {
                if (nums.Length % 2 == 0)
                {
                    int[] result = nums.Skip((nums.Length - k) / 2).Take(k).ToArray();
                    return result;
                }
                else
                {
                    int[] result = nums.Skip((nums.Length - k) / 2).Take(k+1).ToArray();
                    return result;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise92
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test2(new int[] { 10, 20, -30, -40 }, 4));
            Console.WriteLine(Test2(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 4));
            Console.WriteLine(Test(new int[] { 1, 2, 3 }, 2)); 
            Console.WriteLine(Test(new int[] { 10, 20, -30, -40 }, 4)); 

            Console.ReadLine();
        }
        // Write a C# Sharp program to rotate the elements of a given
        // array of integers (length 4 ) in left direction and return the new array.

        public static string Test(int[] arr, int k = 1)
        {
            if(arr == null || arr.Length == 0 || k == 0) return "";

            int n = arr.Length;
            int[] tmp = new int[n];

            for (int i = 0; i < n; i++)
            {
                tmp[(i + k) % n] = arr[i];
            }

            for (int i = 0; i < n; i++)
            {
                arr[i] = tmp[i];
            }
            string output = String.Join(", ", arr);
            return output;
        }

        public static string Test2(int[] nums, int k = 1)
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

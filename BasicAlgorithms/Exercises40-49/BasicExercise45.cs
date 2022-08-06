using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise45
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfNifOneNinRangeReturnX(new int[] {3,7}));
            Console.WriteLine(SumOfNifOneNinRangeReturnX(new int[] {10,11}));
            Console.WriteLine(SumOfNifOneNinRangeReturnX(new int[] {10,20}));
            Console.WriteLine(SumOfNifOneNinRangeReturnX(new int[] {21,220}));
            Console.WriteLine(test(3,7));
            Console.WriteLine(test(10,11));
            Console.WriteLine(test(10,20));
            Console.WriteLine(test(21,220));
            Console.ReadLine();
        }
        // Write a C# Sharp program to compute the sum of the two given integers.
        // If one of the given integer value is in the range 10..20 inclusive return 18.

        public static int SumOfNifOneNinRangeReturnX
            (int[] arr, int min = 10, int max = 20, int x = 18)
        {
            foreach (var num in arr)
            {
                if (num >= min && num <= max) return x;
            }
            return arr.Sum();
        }

        public static int test(int x, int y, int min = 10, int max = 20, int n = 18)
        {
            return (x >= min && x <= max) || (y >= min && y <= max) ? n : x + y;
        }
    }
}

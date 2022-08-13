using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise57
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(new int[] { 4, 5, 7 }));
            Console.WriteLine(test(new int[] { 7, 4, 12 }));
            Console.WriteLine(test(new int[] { 10, 13, 12 }));
            Console.WriteLine(test(new int[] { 18, 12, 13, 5 }));
        }
        //Write a C# Sharp program to compute the sum of N given 
        //integers. However, if any of the values is in the range 10..20 
        //inclusive then that value counts as 0, except 13 and 17.

        public static int test(int[] arr)
        {
            return arr.Where(n => (n < 10 || n > 20 || n == 13 || n == 17)).Sum();
        }
    }
}

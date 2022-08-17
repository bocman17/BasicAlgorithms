using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise91
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new int[] { 10, 20,30, 40, 50 }));
            Console.WriteLine(Test(new int[] { 10, 20, -30, -40, 50 }));
            Console.ReadLine();
        }
        // Write a C# Sharp program to compute the sum of the elements of
        // an given array of integers.

        public static int Test(int[] arr)
        {
            return arr.Sum();
        }
    }
}

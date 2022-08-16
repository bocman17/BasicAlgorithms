using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise89
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new int[] { 10, 20, 40, 50 }));
            Console.WriteLine(Test(new int[] { 10, 20, 40, 10 }));
            Console.WriteLine(Test(new int[] { 12, 24, 35, 55 }));
            Console.ReadLine();
        }
        // Write a C# Sharp program to check a given array of integers of
        // length 1 or more and return true if the first element and the
        // last element are equal in the given array.

        public static bool Test(int[] arr)
        {
            if(arr.First() == arr.Last()) return true;
            else return false;
        }
    }
}

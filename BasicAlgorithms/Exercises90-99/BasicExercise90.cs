using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise90
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new int[] { 10, 20, 40, 50 }, new int[] { 10, 20, 40, 50 }));
            Console.WriteLine(Test(new int[] { 10, 20, 40, 50 }, new int[] { 10, 20, 40, 5 }));
            Console.WriteLine(Test(new int[] { 10, 20, 40, 50 }, new int[] { 1, 20, 40, 5 }));
            Console.ReadLine();
        }
        // Write a C# Sharp program to check a given array of integers of
        // length 1 or more and return true if 10 appears as either first
        // or last element in the given array. 

        public static bool Test(int[] arr1, int[] arr2)
        {
            if(arr1.First() == arr2.First()) return true;
            else if(arr1.Last() == arr2.Last()) return true;
            else return false;
        }
    }
}

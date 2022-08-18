using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise88
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new int[] { 10, 20, 40, 50 }));
            Console.WriteLine(Test(new int[] { 5, 20, 40, 10 }));
            Console.WriteLine(Test(new int[] { 10, 20, 40, 10 }));
            Console.WriteLine(Test(new int[] { 12, 24, 35, 55 }));
            Console.ReadLine();
        }
        // Write a C# Sharp program to check a given array of integers of
        // length 1 or more and return true if 10 appears as either first
        // or last element in the given array. 

        public static bool Test(int[] arr, int target = 10)
        {
            if(arr.First() == target) return true;
            else if(arr.Last() == target) return true;
            else return false;
        }
    }
}

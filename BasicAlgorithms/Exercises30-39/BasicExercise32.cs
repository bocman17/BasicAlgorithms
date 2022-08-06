using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise32
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfNumInArr(new int[] { 1,2,9,3}, 3));
            Console.WriteLine(CheckIfNumInArr(new int[] { 1, 2, 2, 3 }, 2));
            Console.WriteLine(CheckIfNumInArr(new int[] { 1, 2, 2, 3 }, 9));
            Console.ReadLine();
        }
        //Write a C# Sharp program to check a specified number is present in a
        //given array of integers.

        public static bool CheckIfNumInArr(int[] arr, int n)
        {
            return arr.Contains(n);
        }
    }
}

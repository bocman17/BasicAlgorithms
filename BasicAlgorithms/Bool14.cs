using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class Bool14
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfIntIsEqualToNelementsInArr(new int[] { 1, 2, 9, 3 }, 3));
            Console.WriteLine(CheckIfIntIsEqualToNelementsInArr(new int[] { 1, 2, 3, 4, 5, 6 }, 2));
            Console.WriteLine(CheckIfIntIsEqualToNelementsInArr(new int[] { 1, 2, 2, 3 }, 9));
            Console.WriteLine(test(new int[] { 1, 2, 9, 3 }, 3));
            Console.WriteLine(test(new int[] { 1, 2, 3, 4, 5, 6 }, 2));
            Console.WriteLine(test(new int[] { 1, 2, 2, 3 }, 9));
            Console.ReadLine();
        }
        //Write a C# Sharp program to check if one of the first 4 elements in
        //an array of integers is equal to a given element.

        public static bool CheckIfIntIsEqualToNelementsInArr(int[] arr, int x, int n = 4)
        {
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x) return true;
            }
            return false;
        }

        public static bool test(int[] arr, int x, int n = 4)
        {
            return arr.Length < n ? arr.Contains(x) : arr.Take(n).Contains(x);
        }
    }
}

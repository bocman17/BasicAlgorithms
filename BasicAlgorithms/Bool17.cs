using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class Bool17
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfIntOrSumOrDiffIsN(new int[] { 5, 4 }));
            Console.WriteLine(CheckIfIntOrSumOrDiffIsN(new int[] { 4, 3 }));
            Console.WriteLine(CheckIfIntOrSumOrDiffIsN(new int[] { 1, 4 })); 
            Console.WriteLine(CheckIfIntOrSumOrDiffIsN(new int[] { 30,1,1,8,4,7,3,1}));
            Console.WriteLine(test(5, 4));
            Console.WriteLine(test(4, 3));
            Console.WriteLine(test(1, 4));
            Console.WriteLine(test(6, 1));
            Console.ReadLine();
        }
        //  Write a C# Sharp program that accept two integers
        //  and return true if either one is 5 or their sum or difference is 5

        public static bool CheckIfIntOrSumOrDiffIsN(int[] arr, int n = 5)
        {
            foreach (var num in arr)
            {
                if (num == n) return true;
            }

            int count = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                count -= arr[i];
            }

            if (count == 5) return true;

            else if (arr.Sum() == n) return true;

            else return false;
        }

        public static bool test(int x, int y, int n = 5)
        {
            return x == n || y == n || x + y == 5 || x - y == 5;
        }
    }
}

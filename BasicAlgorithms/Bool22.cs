using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class Bool22
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfNumsAreGreaterInSequence(1, 2, 3));
            Console.WriteLine(CheckIfNumsAreGreaterInSequence(4, 5, 6));
            Console.WriteLine(CheckIfNumsAreGreaterInSequence(-1, 1, 0));
            Console.WriteLine(test(1,2,3,4,5,6,7,8));
            Console.WriteLine(test(1,2,3,4,5,6,7,8,-1));
            Console.ReadLine();
        }
        // Write a C# Sharp program to check if y is greater
        // than x, and z is greater than y from three given integers x,y,z.

        public static bool CheckIfNumsAreGreaterInSequence(int x, int y, int z)
        {
            return z > y && y > x;
        }

        public static bool test(params int[] n)
        {
            //for (int i = 0; i < n.Length - 1; i++)
            //{
            //    if (n[i] >= n[i + 1]) return false;
            //}
            //return true;

            int[] arr = new int[n.Length];
            n.CopyTo(arr, 0);
            Array.Sort(n);
            return arr.SequenceEqual(n);
        }
    }
}

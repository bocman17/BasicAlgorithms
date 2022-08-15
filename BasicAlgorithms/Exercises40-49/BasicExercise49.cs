using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise49
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(false, 1, 2, 3));
            Console.WriteLine(Test(true, 4, 5, 6));
            Console.WriteLine(Test(false, 10, 2, 30));
            Console.WriteLine(Test(true, 10, 10, 30));
            Console.ReadLine();
        }
        // Write a C# Sharp program to check if three given numbers are in
        // strict increasing order, such as 4 7 15, or 45, 56, 67, but not
        // 4 ,5, 8 or 6, 6, 8.However,if a fourth parameter is true,
        // equality is allowed, such as 6, 6, 8 or 7, 7, 7.

        public static bool Test(bool equal, params int[] n)
        {
            if (!equal)
            {
                int[] arr = new int[n.Length];
                n.CopyTo(arr, 0);
                Array.Sort(n);
                return arr.SequenceEqual(n);
            }
            else
            {
                for (int i = 0; i < n.Length - 1; i++)
                {
                    if (n[i] > n[i + 1]) return false;
                }
                return true;
            }
        }
    }
}

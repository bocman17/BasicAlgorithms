using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise48
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(1, 2, 3));
            Console.WriteLine(Test(4, 5, 6));
            Console.WriteLine(Test(-1, 1, 0));
            Console.WriteLine(Test(1,2,3,4,5,6,7,8));
            Console.WriteLine(Test(1,2,3,4,5,6,7,8,-1));
            Console.WriteLine(Test(20,30,25,5,1,101,150,22,20));
            Console.ReadLine();
        }
        // Write a C# Sharp program to check if y is greater
        // than x, and z is greater than y from three given integers x,y,z.

        public static bool Test(params int[] n)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise47
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(1, 2, 3));
            Console.WriteLine(Test(4, 5, 6));
            Console.WriteLine(Test(-1, 1, 0));
            Console.WriteLine(Test(5, 2, 3, 8, 9, 27));
            Console.WriteLine(Test(5,2,4));
            Console.WriteLine(Test(5,2,4,11,13,17));
            Console.WriteLine(Test(5,2,4,11,28,18));
            Console.ReadLine();
        }
        // Write a C# Sharp program to check if it is
        // possible to add two integers to get the third integer from three given integers.

        public static bool Test(params int[] n)
        {
            for (int i = 0; i < n.Length; i++)
            {
                for (int j = i + 1; j < n.Length; j++)
                {
                    int result = n[i] + n[j];
                    foreach (var item in n)
                    {
                        if (item == result) return true;
                    }
                }
            }
            return false;
        }
    }
}

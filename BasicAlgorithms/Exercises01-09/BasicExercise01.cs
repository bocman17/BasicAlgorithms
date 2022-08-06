using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise01
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1, 2));
            Console.WriteLine(Sum(3, 2));
            Console.WriteLine(Sum(2, 2)); 
            Console.ReadLine();
        }

        //Write a C# Sharp program to compute the sum of the two given integer values.
        //If the two values are the same, then return triple their sum.

        public static int Sum(int x, int y)
        {
            return x == y ? (x + y) * 3 : x + y;
        }
    }
}

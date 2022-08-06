using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise18
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReturnMax(1, 2, 3));
            Console.WriteLine(ReturnMax(1, 3, 2));
            Console.WriteLine(ReturnMax(1, 1, 1));
            Console.WriteLine(ReturnMax(1, 2, 2));
            Console.ReadLine();
        }
        // Write a C# Sharp program to check the largest number among three given integers.

        public static int ReturnMax(params int[] n)
        {
            return n.Max();
        }
    }
}

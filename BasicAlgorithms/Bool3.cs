using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class Bool3
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfIntIsMultiOf3or7(3));
            Console.WriteLine(CheckIfIntIsMultiOf3or7(14));
            Console.WriteLine(CheckIfIntIsMultiOf3or7(12));
            Console.WriteLine(CheckIfIntIsMultiOf3or7(37));
            Console.ReadLine();
        }

        // Write a C# Sharp program to check if a given positive
        // number is a multiple of 3 or a multiple of 7.

        public static bool CheckIfIntIsMultiOf3or7(int n)
        {
            return n % 3 == 0 || n % 7 == 0;
        }
    }
}

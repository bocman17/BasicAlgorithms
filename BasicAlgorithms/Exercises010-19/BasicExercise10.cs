using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise10
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(3));
            Console.WriteLine(Test(14));
            Console.WriteLine(Test(12));
            Console.WriteLine(Test(37));
            Console.ReadLine();
        }

        // Write a C# Sharp program to check if a given positive
        // number is a multiple of 3 or a multiple of 7.

        public static bool Test(int n)
        {
            return n % 3 == 0 || n % 7 == 0;
        }
    }
}

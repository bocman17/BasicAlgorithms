using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise44
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfXisInRangeYOfMultipleZ(3));
            Console.WriteLine(CheckIfXisInRangeYOfMultipleZ(7));
            Console.WriteLine(CheckIfXisInRangeYOfMultipleZ(8));
            Console.WriteLine(CheckIfXisInRangeYOfMultipleZ(28));
            Console.WriteLine(CheckIfXisInRangeYOfMultipleZ(22));
            Console.WriteLine(CheckIfXisInRangeYOfMultipleZ(28, 4, 11));
            Console.ReadLine();
        }
        // Write a C# Sharp program to check if a given number is
        // within 2 of a multiple of 10.

        public static bool CheckIfXisInRangeYOfMultipleZ(int x, int y = 2, int z = 10)
        {
            return x % z <= y || (x % z) + y >= z;
        }
    }
}

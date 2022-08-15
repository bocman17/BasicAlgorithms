using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise14
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(100, 199));
            Console.WriteLine(Test(250, 300));
            Console.WriteLine(Test(105, 190));
            Console.ReadLine();
        }
        //Write a C# Sharp program to check two given integers
        //whether either of them is in the range 100..200 inclusive.

        public static bool Test(int x, int y, int min = 100, int max = 200)
        {
            return (x >= min && x <= max) || (y >= min && y <= max);
        }
    }
}

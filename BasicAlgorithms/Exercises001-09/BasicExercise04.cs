using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise04
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(103));
            Console.WriteLine(Test(90));
            Console.WriteLine(Test(89));
            Console.ReadLine();
        }

        //Write a C# Sharp program to check a given integer
        //and return true if it is within 10 of 100 or 200.

        public static bool Test
            (int n, int param1 = 100, int param2 = 200, int param3 = 10)
        {
            if (Math.Abs(n - param1) <= param3 || Math.Abs(n - param2) <= param3) return true;
            else return false;
        }
    }
}

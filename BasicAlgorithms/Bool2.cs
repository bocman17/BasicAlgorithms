using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class Bool2
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIntIfIn100Or200(103));
            Console.WriteLine(CheckIntIfIn100Or200(90));
            Console.WriteLine(CheckIntIfIn100Or200(89));
            Console.ReadLine();
        }

        //Write a C# Sharp program to check a given integer
        //and return true if it is within 10 of 100 or 200.

        public static bool CheckIntIfIn100Or200
            (int n, int param1 = 100, int param2 = 200, int param3 = 10)
        {
            if (Math.Abs(n - param1) <= param3 || Math.Abs(n - param2) <= param3) return true;
            else return false;
        }
    }
}

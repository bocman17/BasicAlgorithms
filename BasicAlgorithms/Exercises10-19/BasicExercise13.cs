using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise13
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(120, -1));
            Console.WriteLine(Test(-1, 120));
            Console.WriteLine(Test(2, 120));
            Console.WriteLine(Test(0, 0));
            Console.ReadLine();
        }
        //Write a C# Sharp program to check if one given temperatures is less
        //than 0 and the other is greater than 100.

        public static bool Test(int x, int y)
        {
            return x < 0 && y > 100 || y < 0 && x > 100;
        }
    }
}

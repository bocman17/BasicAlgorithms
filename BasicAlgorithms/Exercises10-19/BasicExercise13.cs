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
            Console.WriteLine(CheckTemperature(120, -1));
            Console.WriteLine(CheckTemperature(-1, 120));
            Console.WriteLine(CheckTemperature(2, 120));
            Console.WriteLine(CheckTemperature(0, 0));
            Console.ReadLine();
        }
        //Write a C# Sharp program to check if one given temperatures is less
        //than 0 and the other is greater than 100.

        public static bool CheckTemperature(int x, int y)
        {
            return x < 0 && y > 100 || y < 0 && x > 100;
        }
    }
}

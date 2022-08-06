using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise3
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckInts(30,0));
            Console.WriteLine(CheckInts(25,5));
            Console.WriteLine(CheckInts(20,30));
            Console.WriteLine(CheckInts(20,25));
            Console.ReadLine();
        }

        //  Write a C# Sharp program to check two given integers,
        //  and return true if one of them is 30 or if their sum is 30.

        public static bool CheckInts(int x, int y)
        {
            return x == 30 || y == 30 || x + y == 30;
            
        }
    }
}

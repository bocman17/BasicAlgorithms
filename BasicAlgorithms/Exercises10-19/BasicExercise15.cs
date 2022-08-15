using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise15
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Test(new int[] { 11, 20, 12 }));
            Console.WriteLine(Test(new int[] { 30, 30, 17 }));
            Console.WriteLine(Test(new int[] { 25, 35, 50 }));
            Console.WriteLine(Test(new int[] { 15, 12, 8 }));
            Console.ReadLine();
        }
        //Write a C# Sharp program to check whether three given
        //integer values are in the range 20..50 inclusive.
        //Return true if 1 or more of them are in the said range otherwise false.

        public static bool Test
            (int[] n, int min = 20, int max = 50)
        {
            foreach(int value in n)
            {
                if (value >= min && value <= max) return true;
                else continue;
            }
            return false;
        }
    }
}

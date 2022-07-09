using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class Integer10
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfTwoInRange(12,17));
            Console.WriteLine(SumOfTwoInRange(2,17));
            Console.WriteLine(SumOfTwoInRange(22,17));
            Console.WriteLine(SumOfTwoInRange(20,0));
            Console.WriteLine(SumOfArrInRange(new int[] {1,2,3}));
            Console.WriteLine(SumOfArrInRange(new int[] {1,2,30}));
            Console.WriteLine(SumOfArrInRange(new int[] {2,10,4}));
            Console.ReadLine();
        }
        //Write a C# Sharp program to compute the sum of the two given integers.
        //If the sum is in the range 10..20 inclusive return 30.

        public static int SumOfTwoInRange
            (int x, int y, int min = 10, int max = 20, int def = 30)
        {
            return x + y >= min && x + y <= max ? def : x + y;
        }
        public static int SumOfArrInRange
            (int[] arr, int min = 10, int max = 20, int def = 30)
        {
            if (arr.Sum() >= min && arr.Sum() <= max) return def;
            else return arr.Sum();
        }
    }
}

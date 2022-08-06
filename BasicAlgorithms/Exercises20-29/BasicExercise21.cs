using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise21
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindLargerValueInRange(78, 95));
            Console.WriteLine(FindLargerValueInRange(20, 30));
            Console.WriteLine(FindLargerValueInRange(21, 25));
            Console.WriteLine(FindLargerValueInRange(28, 28));
            Console.WriteLine(FindLargestValueInRange(new int[] { 70, 88, 99, 101 }));
            Console.WriteLine(FindLargestValueInRange(new int[] { 70, 88, 99, 21 }));
            Console.WriteLine(FindLargestValueInRange(new int[] { 0, 20, 25, 30 }));
            Console.ReadLine();
        }
        //Write a C# Sharp program to find the larger value from two positive
        //integer values that is in the range 20..30 inclusive, or return 0
        //if neither is in that range.

        public static int FindLargerValueInRange(int x, int y, int min = 20, int max = 30)
        {
            bool checkFirstNum = x >= min && x <= max;
            bool checkSecondNum = y >= min && y <= max;

            if (checkFirstNum && checkSecondNum && x == y) return x;

            if (checkFirstNum && checkSecondNum) return x > y ? x : y;

            else if (checkFirstNum && !checkSecondNum) return x;
            else if (!checkFirstNum && checkSecondNum) return y;
            else return 0;
        }

        public static int FindLargestValueInRange(int[] n, int min = 20, int max = 30)
        {
            int[] arrInRange = n.Where(x => x >= min && x <= max).ToArray();
            if (arrInRange.Length == 0) return 0;
            else return arrInRange.Max();
        }
    }
}

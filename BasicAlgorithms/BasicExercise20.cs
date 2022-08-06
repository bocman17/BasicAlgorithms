using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise20
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfIntsAreInRange(78, 95));
            Console.WriteLine(CheckIfIntsAreInRange(25, 35));
            Console.WriteLine(CheckIfIntsAreInRange(40, 50));
            Console.WriteLine(CheckIfIntsAreInRange(55, 60));
            Console.WriteLine(CheckIfIntsAreInRange(new int[] {44,55}));
            Console.WriteLine(CheckIfIntsAreInRange(new int[] {51,55, 56, 60}));
            Console.WriteLine(CheckIfIntsAreInRange(new int[] {1,2,3,4}));
            Console.WriteLine(CheckIfIntsAreInRange(new int[] {40,43,54,55}));
            Console.ReadLine();
        }
        //Write a C# Sharp program to check whether two given integers are
        //in the range 40..50 inclusive, or they are both in the range 50..60 inclusive.

        public static bool CheckIfIntsAreInRange
            (int x, int y, int min1 = 40, int max1 = 50, int min2 = 50, int max2 = 60)
        {
            return (x >= min1 && x <= max1 && y >= min1 && y <= max1) ||
                (x >= min2 && x <= max2 && y >= min2 && y <= max2);
        }
        public static bool CheckIfIntsAreInRange
            (int[] n, int min1 = 40, int max1 = 50, int min2 = 50, int max2 = 60)
        {
            if (n is null)
            {
                throw new ArgumentNullException(nameof(n));
            }

            int count1 = 0;
            int count2 = 0;
            foreach (int x in n)
            {
                if(x >= min1 && x <= max1) count1++;
                if(x >= min2 && x <= max2) count2++;
                if((x < min1 || x > max1) && (x < min2 || x > max2)) return false;
            }

            if (count1 != 0 && count2 != 0) return false;
            else return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class Bool8
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIf2NumbersAreInRange(20, 84));
            Console.WriteLine(CheckIf2NumbersAreInRange(14, 50));
            Console.WriteLine(CheckIf2NumbersAreInRange(11, 45));
            Console.WriteLine(CheckIf2NumbersAreInRange(25, 40));
            Console.WriteLine(CheckIfNumbersAreInRange(new int[] {20,20,20}));
            Console.WriteLine(CheckIfNumbersAreInRange(new int[] {18,17,50}));
            Console.WriteLine(CheckIfNumbersAreInRange(new int[] {50,78,-25,150}));
            Console.ReadLine();
        }
        // Write a C# Sharp program to check whether two given
        // integer values are in the range 20..50 inclusive.
        // Return true if 1 or other is in the said range otherwise false.

        public static bool CheckIf2NumbersAreInRange
            (int x, int y, int min = 20, int max = 50)
        {
            return (x >= min && x <= max && y < min || y > max) ||
                    (y >= min && y <= max && x < min || y > max);
        }

        public static bool CheckIfNumbersAreInRange
            (int[] n, int min = 20, int max = 50)
        {
            int count = 0;
            foreach(int val in n)
            {
                if (val >= min && val <= max) count++;
            }
            if (count == 1) return true;
            else return false;
        }
    }
}

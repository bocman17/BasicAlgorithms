using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise23
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfLastDigitEquals(123, 456));
            Console.WriteLine(CheckIfLastDigitEquals(12, 512));
            Console.WriteLine(CheckIfLastDigitEquals(7, 87));
            Console.WriteLine(CheckIfLastDigitEquals(12, 45));
            Console.WriteLine(CheckIfLastDigitEqualsInArr(12, 45, 55));
            Console.WriteLine(CheckIfLastDigitEqualsInArr(15, 45, 55, 65, 154785));
            Console.WriteLine(CheckIfLastDigitEqualsInArr(1, 2, 3, 4, 10, 20));
            Console.WriteLine(CheckIfLastDigitEqualsInArr(1, 2, 3, 4, 10, 29));
            Console.WriteLine(CheckIfLastDigitEqualsInArr(new int[] { 16, 45, 55, 65, 154785 }));
            Console.ReadLine();
        }
        //Write a C# Sharp program to check if two given non-negative
        //integers have the same last digit.

        //public static bool CheckIfLastDigitEquals(int x, int y)
        //{
        //    string numX = x.ToString();
        //    string numY = y.ToString();

        //    return numX[numX.Length - 1] == numY[numY.Length - 1];
        //}
        public static bool CheckIfLastDigitEquals(int x, int y)
        {
            return Math.Abs(x) % 10 == Math.Abs(y) % 10;
        }

        public static bool CheckIfLastDigitEqualsInArr(params int[] n)
        {
            HashSet<int> set = new HashSet<int>(n);
            HashSet<int> set2 = new HashSet<int>();
            if(set.Count != n.Length) return true;

            else
            {
                for (int i = 0; i < n.Length; i++)
                {
                    n[i] = n[i] % 10;
                    set2.Add(n[i]);
                }
                if (set2.Count != n.Length) return true;

            }
            return false;

        }
    }
}

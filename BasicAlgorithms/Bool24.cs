using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class Bool24
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfAtLeastTwoElemsHaveSameLastDigit(11, 21, 31));
            Console.WriteLine(CheckIfAtLeastTwoElemsHaveSameLastDigit(11, 22, 31));
            Console.WriteLine(CheckIfAtLeastTwoElemsHaveSameLastDigit(11, 22, 33));
            Console.WriteLine(CheckIfAtLeastTwoElemsHaveSameLastDigit(11, 22, 33,145,2226,333355551));
            Console.WriteLine(CheckIfAtLeastTwoElemsHaveSameLastDigit(11, 22, 33,145,2226,333355558));
            Console.ReadLine();
        }
        //  Write a C# Sharp program to check if two or more non-negative
        //  given integers have the same rightmost digit.

        public static bool CheckIfAtLeastTwoElemsHaveSameLastDigit(params int[] n)
        {
            for (int i = 0; i < n.Length; i++)
            {
                for (int j = i + 1; j < n.Length; j++)
                {
                    if (n[i] % 10 == n[j] % 10) return true;
                }
            }
            return false;
        }
    }
}

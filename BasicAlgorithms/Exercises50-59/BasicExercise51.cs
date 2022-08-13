using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise51
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfNumIsNmoreThanTheOthers(new int[] { 11, 21, 31}));
            Console.WriteLine(CheckIfNumIsNmoreThanTheOthers(new int[] { 11, 31}));
            Console.WriteLine(CheckIfNumIsNmoreThanTheOthers(new int[] { 11, 22, 31}));
            Console.WriteLine(CheckIfNumIsNmoreThanTheOthers(new int[] { 10, 20, 15}));
            Console.WriteLine(CheckIfNumIsNmoreThanTheOthers(new int[] { 10, 20, 15, 30}));
        }

        //Write a C# Sharp program to check three given integers and return true 
        //if one of them is 20 more or less than one of the others.

        public static bool CheckIfNumIsNmoreThanTheOthers(int[] arr, int diff = 20)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) >= diff) return true;
                }
            }
            return false;
        }
    }
}

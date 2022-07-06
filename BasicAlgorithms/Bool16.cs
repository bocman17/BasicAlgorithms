using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class Bool16
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckTripleInArr(1, 1, 2, 2, 1));
            Console.WriteLine(CheckTripleInArr(1, 1, 2, 1, 2, 3));
            Console.WriteLine(CheckTripleInArr(1, 1, 1, 2, 2, 2, 1));
            Console.WriteLine(CheckTripleInArr(1, 1, 2, 2, 2));
            Console.ReadLine();
        }
        //Write a C# Sharp program to check if a triple is presents in an array
        //of integers or not. If a value appears three times in a row in an array
        //it is called a triple.

        public static bool CheckTripleInArr(params int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == arr[i + 1] && arr[i] == arr[i + 2]) return true;
            }
            return false;
        }
    }
}

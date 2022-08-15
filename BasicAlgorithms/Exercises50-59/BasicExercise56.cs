using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise56
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new int[] { 4, 5, 7 }));
            Console.WriteLine(Test(new int[] { 7, 4, 12 }));
            Console.WriteLine(Test(new int[] { 10, 13, 12 }));
            Console.WriteLine(Test(new int[] { 18, 12, 13, 5 }));
        }

        //Write a C# Sharp program to compute the sum of the three integers.
        //If one of the values is 13 then do not count it and its right 
        //towards the sum.

        public static int Test(int[] arr)
        {
            int sum = 0;
            if (!arr.Contains(13)) sum = arr.Sum();
            else
            {
                foreach (var num in arr)
                {
                    if (num != 13) sum += num;
                    else break;
                }
            }
            return sum;
        }
    }
}

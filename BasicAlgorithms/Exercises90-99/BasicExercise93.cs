using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise93
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new int[] { 10, 20, -30, -40 }));
            Console.WriteLine(Test(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
            Console.WriteLine(Test(new int[] { 1, 2, 3 })); 
            Console.WriteLine(Test(new int[] { 10, 20, -30, -40 })); 
            Console.WriteLine(Test(new int[] { 10, 20, -30, -40, 50 }));

            Console.ReadLine();
        }
        //  Write a C# Sharp program to reverse a given array of integers and length 5.

        public static string Test(int[] arr)
        {
            return String.Join(" ", arr.Reverse());
        }

    }
}

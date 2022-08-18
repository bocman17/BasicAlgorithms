using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise94
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
        //  Write a C# Sharp program to find out the maximum element between
        //  the first or last element in a given array of integers ( length 4),
        //  replace all elements with maximum element.

        public static string Test(int[] arr)
        {
            arr = arr.Select(n => n = arr.Max()).ToArray();
            return String.Join(" ", arr);
        }

    }
}

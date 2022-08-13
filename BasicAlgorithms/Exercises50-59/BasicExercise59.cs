using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise59
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(new int[] { 4, 5, 6 }));
            Console.WriteLine(test(new int[] { 7, 12, 13 }));
            Console.WriteLine(test(new int[] { -1,0,1 }));
            Console.WriteLine(test(new int[] { 7,14,21, 28 }));
            Console.WriteLine(test(new int[] { 7,4,1 }));
            Console.WriteLine(test(new int[] { 7, 0, 7 }));
            Console.WriteLine(test(new int[] { -7, -5, -3, -2 }));

        }
        //Write a C# Sharp program to check three given integers 
        //(small, medium and large) and return true if the difference between 
        //small and medium and the difference between medium and large is same.

        public static bool test(int[] arr)
        {
            int diff = Math.Abs(arr[1] - arr[0]);
            return arr.Zip(arr.Skip(1), (a, b) => (a + diff) == b || (a - diff) == b).All(x => x);
        }
    }
}

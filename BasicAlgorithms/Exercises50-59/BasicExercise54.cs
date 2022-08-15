using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise54
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new int[] { 11, 21 }));
            Console.WriteLine(Test(new int[] { 11, 20 }));
            Console.WriteLine(Test(new int[] { 10, 10 }));
            Console.WriteLine(Test(new int[] { 10, 10, 10, 10, 20 }));
            Console.WriteLine(Test(new int[] { 10, 10, 10, 10, 10 }));
            Console.WriteLine(Test(new int[] { 7, 14, 21, 49, 70 }));
            Console.WriteLine(Test(new int[] { 123, 456, 789 }));
            Console.WriteLine(Test(new int[] { 1234, 456, 789, 111 }));
        }
        //Write a C# Sharp program to compute the sum of two given non-negative 
        //integers x and y as long as the sum has the same number of digits as x.
        //If the sum has more digits than x then return x without y. 

        public static int Test(int[] arr)
        {
            string[] strArr = arr.Select(x => x.ToString()).ToArray();
            int minLength = strArr.Min(s => s.Length);
            string? shortestInt = strArr.FirstOrDefault(s => s.Length == minLength);

            if (shortestInt == null) return 0;

            int sum = arr.Sum();
            if (shortestInt.Length != sum.ToString().Length) return int.Parse(shortestInt);
            return sum;
        }
    }
}

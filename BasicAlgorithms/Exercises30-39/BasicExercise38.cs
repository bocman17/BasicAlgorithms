using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise38
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test( new int[] { 5, 5, 2 }));
            Console.WriteLine(Test( new int[] { 5, 5, 2, 5, 5 }));
            Console.WriteLine(Test( new int[] { 5, 6, 2, 9 }));
            Console.WriteLine(Test( new int[] { 5, 5, 5, 6 }));
            Console.ReadLine();
        }
        //Write a C# Sharp program to count the number of two 5's are next
        //to each other in an array of integers.
        //Also count the situation where the second 5 is actually a 6. 

        public static int Test(int[] arr, int n = 5, int optional = 6)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (n == arr[i] && (n == arr[i + 1] || optional == arr[i+1])) count++;
            }
            return count;
        }
    }
}

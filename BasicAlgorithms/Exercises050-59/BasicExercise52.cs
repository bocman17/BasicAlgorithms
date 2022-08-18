using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise52
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new int[] { 11, 21 }));
            Console.WriteLine(Test(new int[] { 11, 20}));
            Console.WriteLine(Test(new int[] { 10, 10 }));
            Console.WriteLine(Test(new int[] { 10, 10,10,10,20 }));
            Console.WriteLine(Test(new int[] { 10, 10,10,10,10 }));
            Console.WriteLine(Test(new int[] { 7, 14,21,49,70 }));
        }

        //Write a C# Sharp program to find the larger from two given integers. 
        //However if the two integers have the same remainder when divided by 7,
        //then the return the smaller integer. If the two integers are the same,
        //return 0.

        public static int Test(int[] arr, int divider = 7)
        {
            if (arr.All(x => x == arr[0])) return 0;

            int remainder = arr[0] % 7;
            bool EqualReminder = arr.Skip(1)
                .All(n => n % divider == remainder);

            if (EqualReminder) return arr.Min();
            else return arr.Max();
        }
    }
}

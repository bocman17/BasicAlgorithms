using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise58
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new int[] { 4, 5 }));
            Console.WriteLine(Test(new int[] { 7,12 }));
            Console.WriteLine(Test(new int[] { 10,13 }));
            Console.WriteLine(Test(new int[] { 17,33 }));
            Console.WriteLine(Test(new int[] { 4, 5, 7 }));
            Console.WriteLine(Test(new int[] { 7, 4, 12 }));
            Console.WriteLine(Test(new int[] { 14, 14, 15 }));
            Console.WriteLine(Test(new int[] { 18, 12, 13, 5 }));
            Console.WriteLine(Test(new int[] { 7,0,8,1,3,5,6,-122,12,4,10,2 }));
        }
        //Write a C# Sharp program to check two given integers and return 
        //the value whichever value is nearest to 13 without going over.
        //Return 0 if both numbers go over.

        public static int Test(int[] arr, int target = 13)
        {
            if (arr.All(n => n > target)) return 0;
            else return arr.Aggregate((min, next) => Math.Abs(next - target) >
            Math.Abs(min - target) ? min : next);
        }
    }
}

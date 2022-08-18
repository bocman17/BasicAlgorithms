using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise53
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new int[] { 11, 21 }));
            Console.WriteLine(Test(new int[] { 11, 20 }));
            Console.WriteLine(Test(new int[] { 10, 10 }));
            Console.WriteLine(Test(new int[] { 10, 10, 10, 10, 20 }));
            Console.WriteLine(Test(new int[] { 10, 10, 10, 10, 10 }));
            Console.WriteLine(Test(new int[] { 7, 14, 21, 49, 70 }));
            Console.WriteLine(Test(new int[] { 123, 456, 789}));
            Console.WriteLine(Test(new int[] { 123, 456, 789, 111}));

        }

        //Write a C# Sharp program to check two given integers, 
        //each in the range 10..99. Return true if a digit appears 
        //in both numbers, such as the 3 in 13 and 33.

        public static bool Test(int[] arr)
        {
            string[] strArr = arr.Select(i => i.ToString()).ToArray();
            for (int i = 0; i < strArr.Length; i++)
            {
                foreach (var needle in strArr[i])
                {
                    if (strArr.Skip(i + 1).Any(x => x.Contains(needle))) return true;
                }
            }
            return false;
        }
    }
}

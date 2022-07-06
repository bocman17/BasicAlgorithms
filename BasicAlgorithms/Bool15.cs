using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class Bool15
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsNumberSequenceInArray(new int[] { 1, 1, 2, 3, 1 }, 1,2,3));
            Console.WriteLine(IsNumberSequenceInArray(new int[] { 1, 1, 2, 4, 1 }, 1,2,3));
            Console.WriteLine(IsNumberSequenceInArray(new int[] { 1, 1, 2, 1, 2, 3 }, 1,2,3));
            Console.WriteLine(IsNumberSequenceInArray(new int[] { 1,4,6,8,9,11,13}, 6,8,11));
            Console.WriteLine(test(new int[] { 1, 1, 2, 3, 1 }, new int[] {1,2,3}));
            Console.WriteLine(test(new int[] { 1, 1, 2, 4, 1 }, new int[] {1,2,3}));
            Console.WriteLine(test(new int[] { 1, 1, 2, 1, 2, 3 }, new int[] {1,2,3}));
            Console.WriteLine(test(new int[] { 1, 4, 6, 8, 9, 11, 13 }, new int[] { 6, 8, 11 }));
            Console.WriteLine(test(new int[] { 1, 4, 6, 8, 9, 11, 13 }, new int[] { 8,9,13}));
            Console.ReadLine();
        }
        // Write a C# Sharp program to check whether the sequence of numbers 1, 2, 3
        // appears in a given array of integers somewhere.

        public static bool IsNumberSequenceInArray(int[] arr, params int[] n)
        {
            IEnumerable<int> both = arr.Intersect(n);
            return both.SequenceEqual(n);
        }

        public static bool test(int[] greaterArr, int[] lesserArr)
        {
            for (int i = 0; i < greaterArr.Length - (lesserArr.Length - 1); i++)
            {
                if (greaterArr.Skip(i).Take(lesserArr.Length).SequenceEqual(lesserArr))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

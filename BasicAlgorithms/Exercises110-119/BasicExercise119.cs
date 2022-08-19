using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise119
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 5, 5, 5, 5, 5 }));
            Console.WriteLine(Test(new[] { 1,2,3,4 }));
            Console.WriteLine(Test(new[] { 3, 3, 3, 5, 5, 5 }));
            Console.WriteLine(Test(new[] { 1, 5, 5, 7, 8, 10 }));
            Console.WriteLine(Test(new[] { 1, 5, 9, 10, 17, 5 }));
            Console.WriteLine(Test(new[] { 6, 5, 6 }));
            Console.WriteLine(Test(new[] { 5,3,5,3 }));
            Console.WriteLine(Test(new[] { 6,6,3 }));

            Console.ReadLine();
        }
        // Write a C# Sharp program to check if an array of integers contains
        // a 3 next to a 3 or a 5 next to a 5 or both.

        public static bool Test(int[] nums, int a = 5, int b = 3)
        {
            int[] seq1 = { a, a };
            int[] seq2 = { b, b };

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums.Skip(i).Take(seq1.Length).SequenceEqual(seq1)) return true;
                else if (nums.Skip(i).Take(seq2.Length).SequenceEqual(seq2)) return true;
            }
            return false;
        }
    }
}

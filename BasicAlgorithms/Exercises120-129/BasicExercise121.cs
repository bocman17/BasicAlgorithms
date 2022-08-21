using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise121
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 3, 5, 1, 3, 7 }));
            Console.WriteLine(Test(new[] { 1,2,3,4 }));
            Console.WriteLine(Test(new[] { 3, 3, 3, 5, 5 }));
            Console.WriteLine(Test(new[] { 2, 5, 5, 7, 8, 10 }));
            Console.WriteLine(Test(new[] { 5,3 }));
            Console.WriteLine(Test(new[] { 1,2,3,4,5,3 }));
            Console.ReadLine();
        }
        // Write a C# Sharp program to check a given array of integers and
        // return true if there is a 3 with a 5 somewhere later in the given array. 

        public static bool Test(int[] nums, int a = 5, int b = 3)
        {
            int[] seq1 = { a, b };

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums.Skip(i).Take(seq1.Length).SequenceEqual(seq1) ||
                    nums.Skip(i).Take(seq1.Length).SequenceEqual(seq1.Reverse())) return true;
            }
            return false;
        }
    }
}

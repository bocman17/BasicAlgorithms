using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise55
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(new int[] { 4,5,7 }));
            Console.WriteLine(test(new int[] { 7,4,12 }));
            Console.WriteLine(test(new int[] { 10, 10,12 }));
            Console.WriteLine(test(new int[] { 18, 12, 12 }));
        }
        //Write a C# Sharp program to compute the sum of three given integers.
        //If the two values are same return the third value. 
        public static int test(int[] arr)
        {
            HashSet<int> set = new HashSet<int>(arr);

            if (set.Count == arr.Length) return arr.Sum();
            else
            {
                int firstNonDuplicate = arr.GroupBy(i => i)
                    .Where(g => g.Count() == 1).Select(g => g.Key).FirstOrDefault();
                return firstNonDuplicate;
            }
        }
    }
}

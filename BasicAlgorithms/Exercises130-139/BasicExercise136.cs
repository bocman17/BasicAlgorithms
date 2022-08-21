using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise136
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { "a", "b", "bb", "c", "ccc" }, 1));
            Console.WriteLine(Test(new[] { "Daniel", "Tasja", "Bocman", "Kamila", "Franta" }, 6));
            Console.ReadLine();
        }
        // Write a C# Sharp program to count the number of strings with given
        // length in given array of strings.
        static int Test(string[] arrStr, int n)
        {
            return arrStr.Where(s => s.Length == n).ToArray().Length;
        }
    }
}

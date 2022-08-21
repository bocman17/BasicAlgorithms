using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise138
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { "a", "aaa", "b", "bbb", "c", "ccc" }, 1));
            Console.WriteLine(Test(new[] { "Daniel", "Tasja", "Bocman", "Kamila", "Franta" }, 0));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new array from a given array
        // of strings  using all the strings whose length are matched with given
        // string length.
        static string Test(string[] arrStr, int n)
        {
            return String.Join(" ", arrStr.Where(s => s.Length == n).ToArray());
        }
    }
}

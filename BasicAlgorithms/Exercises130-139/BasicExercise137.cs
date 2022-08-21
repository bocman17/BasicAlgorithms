using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise137
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { "a", "b", "bb", "c", "ccc" }, 3));
            Console.WriteLine(Test(new[] { "Daniel", "Tasja", "Bocman", "Kamila", "Franta" }, 8));
            Console.ReadLine();
        }
        //Write a C# Sharp program to create a new array using the first n strings
        //from a given array of strings. (n>=1 and <=length of the array). 
        static string Test(string[] arrStr, int n)
        {
            if(n <= 0) return String.Join(" ", arrStr);
            else
            {
                return String.Join(" ", arrStr.Take(n));
            }
        }
    }
}

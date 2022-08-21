using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise146
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", Test(new List<int> { 10, 22, 35, 41 })));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new list of the rightmost digits
        // from a given list of positive integers.
        static List<int> Test(List<int> intList)
        {
            return intList.Select(n => n % 10).ToList();
        }
    }
}

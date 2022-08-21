using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise145
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", Test(new List<int> { 1,2,3,4})));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new list from a given list of integers
        // where each integer value is added to 2 and the result value is multiplied by 5.
        static List<int> Test(List<int> intList, int add = 2, int multi = 5)
        {
            return intList.Select(n => (n + add) * multi).ToList();
        }
    }
}

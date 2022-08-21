using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise149
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", Test(new List<int> { 0, -2, 1, 2, 3, 5, 4, 7, 8 })));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new list from a given list of
        // integers removing those values which are less than 4.
        static List<int> Test(List<int> strList, int a = 4)
        {
            return strList.Where(n => n < a).ToList();
        }
    }
}

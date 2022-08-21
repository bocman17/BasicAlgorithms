using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise150
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", Test(new List<int> { 10, 22, 35, 47, 53, 67 })));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new list from a given list of integers
        // removing those values end with 7.
        static List<int> Test(List<int> strList, int a = 7)
        {
            return strList.Where(n => n % 10 != a).ToList();
        }
    }
}

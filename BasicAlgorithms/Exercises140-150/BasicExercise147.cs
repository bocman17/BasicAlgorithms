using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise147
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", Test(new List<string> { "Abc", "cdef", "js", "php" })));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new list from a given list of strings
        // where strings will be in upper case in new string.
        static List<string> Test(List<string> strList)
        {
            return strList.Select(s => s.ToUpper()).ToList();
        }
    }
}

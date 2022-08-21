using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise143
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", Test(new List<string> { "1", "2", "3", "4"})));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new list from a given list of
        // strings where each element has "#" added at the beginning and end position.
        static List<string> Test(List<string> strList, char c = '#')
        {
            return strList.Select(s => c + s + c).ToList();
        }
    }
}

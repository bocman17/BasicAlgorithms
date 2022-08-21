using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise144
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", Test(new List<string> { "1", "2", "3", "4"})));
            Console.WriteLine(String.Join(" ", Test(new List<string> { "Tasja", "Daniel", "Bocman", "Kamila"}, 2)));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new list from a given list of
        // strings where each element is replaced by 4 copies of the string
        // concatenated together.
        static List<string> Test(List<string> strList, int copies = 4)
        {
            return strList.Select(s => 
            String.Join("",Enumerable.Repeat(s, copies))).ToList();
        }
    }
}

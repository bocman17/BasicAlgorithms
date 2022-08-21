using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise148
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", Test(new List<string> { "abc", "cdaef", "js", "php" })));
            Console.WriteLine(String.Join(" ", Test(new List<string> { "aaaa", "abab", "amanda", "pocahontas" })));
            Console.ReadLine();
        }
        // Write a C# Sharp program to remove all "a" in each string in given list
        // of strings and return the new string.
        static List<string> Test(List<string> strList, char c = 'a')
        {
            return strList.Select(s => Regex.Replace(s, c.ToString(), "")).ToList();
        }
    }
}

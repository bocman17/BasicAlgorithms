using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise141
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", Test(new List<int> { 1,2,3,4})));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new list from a given list of
        // integers where each element is multiplied by 3.
        static List<int> Test(List<int> nums, int n = 3)
        {
            nums = nums.Select(num => num * n).ToList();
            return nums;
        }
    }
}

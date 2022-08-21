using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise139
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(123));
            Console.WriteLine(Test(13));
            Console.WriteLine(Test(222));
            Console.ReadLine();
        }
        // Write a C# Sharp program to check a positive integer and return true if it
        // contains a number 2.
        static bool Test(int n, int a = 2)
        {
            return n.ToString().Contains(a.ToString());
        }
    }
}

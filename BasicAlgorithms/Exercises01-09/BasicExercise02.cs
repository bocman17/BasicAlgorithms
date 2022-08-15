using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise02
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(53));
            Console.WriteLine(Test(30));
            Console.WriteLine(Test(51)); 
            Console.ReadLine();
        }

        // Write a C# Sharp program to get the absolute difference between n and 51.
        // If n is greater than 51 return triple the absolute difference.

        public static int Test(int n, int param = 51)
        {
            return n > param ? (n - param) * 3 : param - n;
        }
    }
}

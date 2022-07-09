using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class Bool18
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfXisMultipleOfNorOneMore(13));
            Console.WriteLine(CheckIfXisMultipleOfNorOneMore(14));
            Console.WriteLine(CheckIfXisMultipleOfNorOneMore(27));
            Console.WriteLine(CheckIfXisMultipleOfNorOneMore(41));
            Console.ReadLine();
        }
        // Write a C# Sharp program to test if a given non-negative number is a multiple of 13
        // or it is one more than a multiple of 13.

        public static bool CheckIfXisMultipleOfNorOneMore(int x, int n = 13)
        {
            return x % n == 0 || x % n == 1;
        }
    }
}

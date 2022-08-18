using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise74
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new string[] {"Hello", "Python", "on", "o"}, 2));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new string of length 2 starting at
        // the given index of a given string.

        public static string Test(string[] strArr, int index, int length = 2)
        {
            strArr = strArr.Where(s => s.Length > length).Select(s => s.Substring(index, length)).ToArray();
            string output = String.Join(", ", strArr);
            return output;
        }
    }
}

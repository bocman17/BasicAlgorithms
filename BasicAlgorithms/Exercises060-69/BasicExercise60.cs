using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise60
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new string[] { "Daniel", "Tasja", "Tommy" }));
            Console.WriteLine(Test(new string[] { "Daniel", "Tasja" }));
            Console.ReadLine();
        }
        //  Write a C# Sharp program to create a new string using two given
        //  strings s1, s2, the format of the new string will be s1s2s2s1.

        public static string Test(string[] strArr)
        {
            string initial = strArr[0];
            string output = initial;

            for (int i = 1; i < strArr.Length; i++)
            {
                output += strArr[i] + strArr[i] + initial;
            }

            return output;

        }
    }
}

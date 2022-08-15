using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise78
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("abc", "cat"));
            Console.WriteLine(Test("python", "php"));
            Console.WriteLine(Test("php", "php"));
            Console.ReadLine();
        }
        // Write a C# Sharp program to combine two given strings (lowercase).
        // If there are any double character in new string then omit one character. 

        public static string Test(string s1, string s2)
        {
            string output = s1 + s2;
            for (int i = 0; i < output.Length - 1; i++)
            {
                if (output[i] == output[i + 1]) output = output.Remove(i, 1);
            }

            return output;
        }
    }
}

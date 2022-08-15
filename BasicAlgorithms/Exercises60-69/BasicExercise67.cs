using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise67
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new string[] {"Daniel", "Tasja"}));
            Console.WriteLine(Test(new string[] {"JS", "Python"}));
            Console.WriteLine(Test(new string[] {"JS", "Python", "Kotlin", "Sequel"}));
            Console.ReadLine();
        }
        // Write a C# Sharp program to concat two given string of length atleast 1,
        // after removing their first character.

        public static string Test(string[] strArr)
        {
            strArr = strArr.Select(str => str[1..]).ToArray();
            string output = String.Join("", strArr);
            return output;
        }
    }
}

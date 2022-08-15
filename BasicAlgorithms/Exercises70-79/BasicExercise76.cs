using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise76
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new string[] {"Hello", "Python", "Tasja", "Tomas", "", "a"}, 3));
            Console.WriteLine(Test(new string[] { "", "a"}));
            Console.ReadLine();
        }
        // Write a C# Sharp program to create a new string of length 2,
        // using first two characters of a given string. If the given string
        // length is less than 2 use '#' as missing characters. 

        public static string Test(string[] strArr, int n = 2)
        {
            string[] shortLengthStrArr = strArr.Where(s => s.Length <= n).ToArray();
            strArr = strArr.Where(s => s.Length > n).Select(s => s[..n]).ToArray();
            for (int i = 0; i < shortLengthStrArr.Length; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (shortLengthStrArr[i].Length < n)
                    {
                        shortLengthStrArr[i] += "#"; 
                    }
                }
            }
            strArr = strArr.Concat(shortLengthStrArr).ToArray();
            string output = String.Join(", ", strArr);
            return output;
        }
    }
}

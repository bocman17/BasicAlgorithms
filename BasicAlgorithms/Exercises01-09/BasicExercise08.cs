using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise08
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CopyFrontCharacters("abcd",3, 3));
            Console.WriteLine(CopyFrontCharacters("JS"));
            Console.WriteLine(CopyFrontCharacters("a"));
            Console.ReadLine();
        }

        //Write a C# Sharp program to create a
        //new string which is 4 copies of the 2 front characters of a given string.
        //If the given string length is less than 2 return the original string.

        public static string CopyFrontCharacters(string s, int count = 4, int charsToCopy = 2)
        {
            if (s.Length < charsToCopy) return s;
            else
            {
                string tocopy = s.Substring(0, charsToCopy);
                var builder = new StringBuilder(charsToCopy * count);
                for (int i = 0; i < count; i++) builder.Append(tocopy);
                return builder.ToString();
            }
        }

        //public static string CopyFrontCharacters(string str)
        //{
        //    return str.Length < 2 ? str : str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2);
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise24
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("Python", 3));
            Console.WriteLine(Test("Javascript", 3));
            Console.WriteLine(Test("js", 3));
            Console.WriteLine(Test("PHP", 3));
            Console.WriteLine(Test2("tom", 4));
            Console.WriteLine(Test2("Daniel", 1));
            Console.WriteLine(Test2("Automaton", 6));
            Console.ReadLine();
        }
        //Write a C# Sharp program to convert the last 3 characters of a
        //given string in upper case. If the length of the string has less
        //than 3 then uppercase all the characters. 

        public static string Test(string s, int n)
        {
            if(s.Length < n)
            {
                return s.ToUpper();
            }
            else
            {
                string sub = s.Substring(s.Length - n);
                string output = s.Substring(0, s.Length - n) + sub.ToUpper();
                return output;
            }
        }
        public static string Test2(string str, int n)
        {
            return str.Length < n ? str.ToUpper() : str.Remove(str.Length - n) + str.Substring(str.Length - n).ToUpper();
        }
    }
}

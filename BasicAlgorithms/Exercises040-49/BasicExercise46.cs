using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise46
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("FizzBuzz"));
            Console.WriteLine(Test("Fizz"));
            Console.WriteLine(Test("Buzz"));
            Console.WriteLine(Test("Founder"));
            Console.WriteLine(Test("FoundeB"));
            Console.WriteLine(Test("aoundeB"));
            Console.WriteLine(Test("FizzBuzz"));
            Console.WriteLine(Test("Fizz"));
            Console.WriteLine(Test("Buzz"));
            Console.WriteLine(Test("Founder"));
            Console.WriteLine(Test("FoundeB"));
            Console.WriteLine(Test("aoundeB"));
            Console.ReadLine();
        }
        // Write a C# Sharp program to check whether a given string starts with "F"
        // or ends with "B". If the string starts with "F" return "Fizz" and return
        // "Buzz" if it ends with "B" If the string starts with "F" and ends with "B"
        // return "FizzBuzz". In other cases return the original string.

        public static string Test(string s)
        {
            if (s.StartsWith('F') && s.EndsWith('B')) return "FizzBuzz";
            else if (s.StartsWith('F')) return "Fizz";
            else if (s.EndsWith('B')) return "Buzz";
            else return s;
        }
        public static string Test
            (string s, char a = 'F', char b = 'B', string x = "Fizz", string y = "Buzz")
        {
            if (s.StartsWith(a) && s.EndsWith(b)) return x + y;
            else if (s.StartsWith(a)) return x;
            else if (s.EndsWith(b)) return y;
            else return s;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class String15
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FizzBuzz("FizzBuzz"));
            Console.WriteLine(FizzBuzz("Fizz"));
            Console.WriteLine(FizzBuzz("Buzz"));
            Console.WriteLine(FizzBuzz("Founder"));
            Console.WriteLine(FizzBuzz("FoundeB"));
            Console.WriteLine(FizzBuzz("aoundeB"));
            Console.WriteLine(test("FizzBuzz"));
            Console.WriteLine(test("Fizz"));
            Console.WriteLine(test("Buzz"));
            Console.WriteLine(test("Founder"));
            Console.WriteLine(test("FoundeB"));
            Console.WriteLine(test("aoundeB"));
            Console.ReadLine();
        }
        // Write a C# Sharp program to check whether a given string starts with "F"
        // or ends with "B". If the string starts with "F" return "Fizz" and return
        // "Buzz" if it ends with "B" If the string starts with "F" and ends with "B"
        // return "FizzBuzz". In other cases return the original string.

        public static string FizzBuzz(string s)
        {
            if (s.StartsWith('F') && s.EndsWith('B')) return "FizzBuzz";
            else if (s.StartsWith('F')) return "Fizz";
            else if (s.EndsWith('B')) return "Buzz";
            else return s;
        }
        public static string test
            (string s, char a = 'F', char b = 'B', string x = "Fizz", string y = "Buzz")
        {
            if (s.StartsWith(a) && s.EndsWith(b)) return x + y;
            else if (s.StartsWith(a)) return x;
            else if (s.EndsWith(b)) return y;
            else return s;
        }
    }
}

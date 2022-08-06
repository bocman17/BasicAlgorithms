using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class BasicExercise19
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReturnNearestNumToN(78, 95));
            Console.WriteLine(ReturnNearestNumToN(95, 95));
            Console.WriteLine(ReturnNearestNumToN(99, 70));
            Console.WriteLine(ReturnNearestNumToN(99, 101));
            Console.WriteLine(ReturnNearestNumToN(94, 105));
            Console.WriteLine(ReturnNearestNumToN(new int[] {98,102}));
            Console.WriteLine(ReturnNearestNumToN(new int[] {98,102, 101}));
            Console.WriteLine(ReturnNearestNumToN(new int[] {98,102, 150}));
            Console.WriteLine(ReturnNearestNumToN(new int[] {2,2,89}));
            Console.ReadLine();
        }
        //Write a C# Sharp program to check which number nearest
        //to the value 100 among two given integers. Return 0 if
        //the two numbers are equal.

        public static int ReturnNearestNumToN(int x, int y, int n = 100)
        {
            if (Math.Abs(n - x) > Math.Abs(n - y)) return y;
            else if (Math.Abs(n - x) < Math.Abs(n - y)) return x;
            else return 0;
        }

        public static int ReturnNearestNumToN(int[] list, int n = 100 )
        {
            //TODO
            if(list.Length != list.Distinct().Count()) { return 0; }
            var nearest = list.Aggregate((current, next) => 
            Math.Abs((long)current - n) < Math.Abs((long)next - n) ? current : next);
            return nearest;
        }
    }
}

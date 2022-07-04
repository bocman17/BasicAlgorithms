using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    internal class Bool12
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindIfCharFirstAppearanceIsFollowedBySameChar("caabb", 'a'));
            Console.WriteLine(FindIfCharFirstAppearanceIsFollowedBySameChar("babaaba", 'a'));
            Console.WriteLine(FindIfCharFirstAppearanceIsFollowedBySameChar("aaaaa", 'a'));
            Console.ReadLine();
        }
        //Write a C# Sharp program to check if the first appearance of "a"
        //in a given string is immediately followed by another "a".

        public static bool FindIfCharFirstAppearanceIsFollowedBySameChar
            (string s, char c)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    return s[i] == s[i + 1];
                }
            }
            return false;
        }
    }
}

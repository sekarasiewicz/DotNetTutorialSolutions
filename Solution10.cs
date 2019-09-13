using System;
using System.Linq;

namespace Exercises
{
    class Solution10 {
        private static readonly char[] Vowels = { 'a', 'e', 'o', 'u', 'i' };
        
        
        public int CountVowels()
        {
            Console.WriteLine("Count number of vowels {a, e, o, u, i} in word");

            var rl = Console.ReadLine();

            return rl?.ToCharArray().Count(r => Array.IndexOf(Vowels, r) != -1) ?? 0;
        }
    }
}

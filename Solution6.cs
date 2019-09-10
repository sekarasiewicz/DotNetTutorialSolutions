using System;
using System.Linq;

namespace Exercises
{
    class Solution6
    {
        public string revertString()
        {
            Console.WriteLine("Write Name to revert");

            var rl = Console.ReadLine().ToArray();
            Array.Reverse(rl);

            return String.Join("", rl);
        }
    }
}

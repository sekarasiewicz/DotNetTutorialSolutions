using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    class Solution5
    {
        public int maxNumber()
        {
            Console.WriteLine("Write List of numbers, separated by comma to get Biggest of them!");

            //var rl = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
            int[] rl = Console.ReadLine().Split(',').Select(n => Convert.ToInt32(n)).ToArray();

            return rl.Max();
        }
    }
}

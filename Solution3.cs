using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    class Solution3
    {
        public string strong()
        {
            Console.WriteLine("Provide number the sum");
            var rl = Int64.Parse(Console.ReadLine());

            var sum = rl;

            for (var i = rl-1; i >= 1; i--)
            {
                sum *= i;
                Console.WriteLine("Current SUM: " + sum);
            }

           
            return string.Format("{0}! = {1}", rl, sum);
        }
    }
}

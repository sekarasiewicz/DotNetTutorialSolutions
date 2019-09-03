using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    class Solution2
    {
        public int sumValues()
        {
            Console.WriteLine("Provide number or ok, to exit and sum");
            var sum = 0;

            while(true)
            {
                var rl = Console.ReadLine();

                if (rl == "ok" || string.IsNullOrEmpty(rl))
                {
                    break;
                } else
                {
                    sum += Int32.Parse(rl);
                }
                Console.WriteLine("Current SUM: " + sum);
            }
            return sum;
        }
    }
}

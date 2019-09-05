using System;

namespace Exercises
{
    class Solution4
    {
        public string guesNumber()
        {
            var random = new Random();
            var randNumber = random.Next(1, 10);

            Console.WriteLine("Gues number from 1 to 10!");
            Console.WriteLine("Pst, The Answer is: {0}", randNumber);

            var rl = Int64.Parse(Console.ReadLine());

            if (rl > 10 || rl < 1)
            {
                return "WRONG NUMBER YOU STUPID!";
            }

            if (rl == randNumber)
            {
                return "EXELENT YOU WON!";
            }
            return "TRY AGAIN";
        }
    }
}

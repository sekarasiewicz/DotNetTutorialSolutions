using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercises
{
    class Solution7
    {
        public string distinctList()
        {
            Console.WriteLine("Write numbers to the list, those numbers i will make unique and sort :), Quit to Exit");
            var myList = new List<int>();

            while (true)
            {
                var rl = Console.ReadLine();

                var isNumeric = int.TryParse(rl, out var rlp);

                if (rl != null && rl.ToLower() == "quit")
                {
                    break;
                } else if (!isNumeric)
                {
                    continue;
                }
                myList.Add(rlp);
            }

            var dList = myList.Distinct().ToList();
            dList.Sort();

            return string.Join(", ", dList);
        }
    }
}

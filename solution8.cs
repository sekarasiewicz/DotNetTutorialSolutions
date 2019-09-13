using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercises
{
    class Solution8
    {
        public string checkHour()
        {
            Console.WriteLine("Type hour in format hh:mm");
            var myList = new List<int>();

            var rl = Console.ReadLine();

            try
            {
                var dateTime = DateTime.ParseExact(rl, "HH:mm", CultureInfo.InvariantCulture);
                return "OK";
            }
            catch (Exception e)
            {
                return "Invalid Time";
            }
        }
    }
}
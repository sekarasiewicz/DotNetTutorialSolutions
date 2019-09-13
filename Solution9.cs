using System;
using System.Globalization;
using System.Text;

namespace Exercises
{
    class Solution9 {
        public string CamelCase()
        {
            Console.WriteLine("Write numbers to the list, those numbers i will make unique and sort :), Quit to Exit");
            
            var rl = Console.ReadLine();

            if (rl == null) return "";
            var rls = rl.Split(' ');

            var builder = new StringBuilder();
            
            foreach (var r in rls)
            {
                builder.Append(CultureInfo.InvariantCulture.TextInfo.ToTitleCase(r));
            }

            return builder.ToString();
        }
    }
}

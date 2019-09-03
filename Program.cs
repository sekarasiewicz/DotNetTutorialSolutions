using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(@"Chose solution: 
1) Divider
2) Sum all numbes

Enter to exit:");
            var s = Console.ReadLine();

            switch(s)
            {
                case "1":
                    var solution1 = new Solution1();
                    Console.WriteLine(solution1.dividersCount(100, 3));
                    break;
                case "2":
                    var solution2 = new Solution2();
                    Console.WriteLine(solution2.sumValues());
                    break;
            }
        }
    }
}

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
3) strong!
4) Gues Random
5) Max number
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
                case "3":
                    var solution3 = new Solution3();
                    Console.WriteLine(solution3.strong());
                    break;
                case "4":
                    var solution4 = new Solution4();
                    Console.WriteLine(solution4.guesNumber());
                    break;
                case "5":
                    var solution5 = new Solution5();
                    Console.WriteLine(solution5.maxNumber());
                    break;
            }
        }
    }
}

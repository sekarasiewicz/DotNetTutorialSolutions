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
4) guest Random
5) Max number
6) Revert String
7) Sorted unique list
8) Check hour
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
                case "6":
                    var solution6 = new Solution6();
                    Console.WriteLine(solution6.revertString());
                    break;
                case "7":
                    var solution7 = new Solution7();
                    Console.WriteLine(solution7.distinctList());
                    break;
                case "8":
                    var solution8= new Solution8();
                    Console.WriteLine(solution8.checkHour());
                    break;
            }
        }
    }
}

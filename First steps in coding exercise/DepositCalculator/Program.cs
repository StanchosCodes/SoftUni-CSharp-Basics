using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int deadline = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double risedPercent = deposit * (percent / 100);
            double monthlyPercent = risedPercent / 12;
            double sum = deposit + deadline * monthlyPercent;

            Console.WriteLine(sum);
        }
    }
}

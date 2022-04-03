using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int gpu = int.Parse(Console.ReadLine());
            int cpu = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            const double gpuPrice = 250;

            double gpuTotalPrice = gpu * gpuPrice;
            double cpuPrice = gpuTotalPrice * 0.35;
            double cpuTotalPrice = cpu * cpuPrice;
            double ramPrice = gpuTotalPrice * 0.10;
            double ramTotalPrice = ram * ramPrice;

            double sum = gpuTotalPrice + cpuTotalPrice + ramTotalPrice;

            if (gpu > cpu)
            {
                sum *= 0.85;
            }

            double finalMoney = Math.Abs(budget - sum);
            if (budget >= sum)
            {
                Console.WriteLine($"You have {finalMoney:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {finalMoney:f2} leva more!");
            }


        }
    }
}

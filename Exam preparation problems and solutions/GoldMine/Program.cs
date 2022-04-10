using System;

namespace GoldMine
{
    class Program
    {
        static void Main(string[] args)
        {
            int locations = int.Parse(Console.ReadLine());

            for (int i = 0; i < locations; i++)
            {
                double expectedAverageIncome = double.Parse(Console.ReadLine());
                int daysToDig = int.Parse(Console.ReadLine());

                double incomeForCurrentLocation = 0;

                for (int j = 0; j < daysToDig; j++)
                {
                    double incomePerDay = double.Parse(Console.ReadLine());

                    incomeForCurrentLocation += incomePerDay;
                }
                double averageIncomeForCurrentLocation = incomeForCurrentLocation / daysToDig;
                if (averageIncomeForCurrentLocation >= expectedAverageIncome)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averageIncomeForCurrentLocation:f2}.");
                }
                else
                {
                    Console.WriteLine($"You need {expectedAverageIncome - averageIncomeForCurrentLocation:f2} gold.");
                }
            }
        }
    }
}

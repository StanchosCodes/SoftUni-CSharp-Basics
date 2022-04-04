using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string restingPlace = "";
            double spendMoney = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    restingPlace = "Camp";
                    spendMoney = budget * 0.30;
                }
                else
                {
                    restingPlace = "Hotel";
                    spendMoney = budget * 0.70;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    restingPlace = "Camp";
                    spendMoney = budget * 0.40;
                }
                else
                {
                    restingPlace = "Hotel";
                    spendMoney = budget * 0.80;
                }
            }
            else
            {
                destination = "Europe";
                restingPlace = "Hotel";
                spendMoney = budget * 0.90;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{restingPlace} - {spendMoney:f2}");
        }
    }
}

using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string checkIn = "";
            string location = "";
            double price = 0;

            if (budget <= 1000)
            {
                checkIn = "Camp";

                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        price = budget * 0.65;
                        break;
                    case "Winter":
                        location = "Morocco";
                        price = budget * 0.45;
                        break;
                }
            }
            else if (budget <= 3000)
            {
                checkIn = "Hut";

                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        price = budget * 0.80;
                        break;
                    case "Winter":
                        location = "Morocco";
                        price = budget * 0.60;
                        break;
                }
            }
            else if (budget > 3000)
            {
                checkIn = "Hotel";

                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        price = budget * 0.90;
                        break;
                    case "Winter":
                        location = "Morocco";
                        price = budget * 0.90;
                        break;
                }
            }

            Console.WriteLine($"{location} - {checkIn} - {price:f2}");
        }
    }
}

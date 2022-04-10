using System;

namespace CourierExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int kilometers = int.Parse(Console.ReadLine());

            double pricePerKilometer = 0;
            double percentage = 0;
            double finalPrice = 0;
            double markupPerKilometer = 0;
            double totalMarkup = 0;

            if (weight < 1)
            {
                pricePerKilometer = 0.03;
            }
            else if (weight < 10)
            {
                pricePerKilometer = 0.05;
            }
            else if (weight < 40)
            {
                pricePerKilometer = 0.10;
            }
            else if (weight < 90)
            {
                pricePerKilometer = 0.15;
            }
            else if (weight < 150)
            {
                pricePerKilometer = 0.20;
            }

            double transportPrice = pricePerKilometer * kilometers;

            switch (type)
            {
                case "standart":
                    finalPrice = pricePerKilometer * kilometers;
                    break;
                case "express":
                    if (weight < 1)
                    {
                        percentage = pricePerKilometer * 0.8;
                    }
                    else if (weight < 10)
                    {
                        percentage = pricePerKilometer * 0.4;
                    }
                    else if (weight < 40)
                    {
                        percentage = pricePerKilometer * 0.05;
                    }
                    else if (weight < 90)
                    {
                        percentage = pricePerKilometer * 0.02;
                    }
                    else if (weight < 150)
                    {
                        percentage = pricePerKilometer * 0.01;
                    }
                    markupPerKilometer = percentage * weight;
                    totalMarkup = markupPerKilometer * kilometers;
                    break;
            }

            double totalMoney = transportPrice + totalMarkup;

            Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {totalMoney:f2} lv.");
        }
    }
}

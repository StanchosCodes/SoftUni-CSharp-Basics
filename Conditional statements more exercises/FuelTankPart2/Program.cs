using System;

namespace FuelTankPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();

            double price = 0;

            switch (fuelType)
            {
                case "Diesel":
                    price = 2.33;

                    if (clubCard == "Yes")
                    {
                        price -= 0.12;
                    }
                    break;
                case "Gasoline":
                    price = 2.22;
                    if (clubCard == "Yes")
                    {
                        price -= 0.18;
                    }
                    break;
                case "Gas":
                    price = 0.93;
                    if (clubCard == "Yes")
                    {
                        price -= 0.08;
                    }
                    break;
            }

            double sumLitresPrice = price * quantity;

            if (quantity >= 20 && quantity <= 25)
            {
                sumLitresPrice *= 0.92;
            }
            else if (quantity > 25)
            {
                sumLitresPrice *= 0.90;
            }

            Console.WriteLine($"{sumLitresPrice:f2} lv.");
        }
    }
}

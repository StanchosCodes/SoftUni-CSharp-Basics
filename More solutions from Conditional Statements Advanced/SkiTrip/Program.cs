using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string ocenka = Console.ReadLine();

            const double roomForOnePersonPrice = 18.00;
            const double apartmentPrice = 25.00;
            const double presidentApartmentPrice = 35.00;

            double price = 0;
            days = days - 1;

            switch (typeOfRoom)
            {
                case "room for one person":
                    price = days * roomForOnePersonPrice;
                    break;
                case "apartment":
                    price = days * apartmentPrice;
                    if (days < 10)
                    {
                        price -= price * 0.30;
                    }
                    else if (days < 15)
                    {
                        price -= price * 0.35;
                    }
                    else
                    {
                        price -= price * 0.50;
                    }
                    break;
                case "president apartment":
                    price = days * presidentApartmentPrice;
                    if (days < 10)
                    {
                        price -= price * 0.10;
                    }
                    else if (days < 15)
                    {
                        price -= price * 0.15;
                    }
                    else
                    {
                        price -= price * 0.20;
                    }
                    break;
            }
            if (ocenka == "positive")
            {
                price += price * 0.25;
            }
            else
            {
                price -= price * 0.10;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}

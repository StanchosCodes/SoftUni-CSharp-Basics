using System;

namespace SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string type = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            double pricePerPerson = 0;
            string sport = "";

            switch (season)
            {
                case "Winter":
                    switch (type)
                    {
                        case "boys":
                        case "girls":
                            pricePerPerson = 9.60;
                    break;
                        case "mixed":
                            pricePerPerson = 10;
                            break;
                    }
                    break;
                case "Spring":
                    switch (type)
                    {
                        case "boys":
                        case "girls":
                            pricePerPerson = 7.20;
                            break;
                        case "mixed":
                            pricePerPerson = 9.50;
                            break;
                    }
                    break;
                case "Summer":
                    switch (type)
                    {
                        case "boys":
                        case "girls":
                            pricePerPerson = 15;
                            break;
                        case "mixed":
                            pricePerPerson = 20;
                            break;
                    }
                    break;
            }

            double totalPrice = quantity * pricePerPerson * nights;
            double discount = 0;
            if (quantity >= 50)
            {
                discount = 0.5;
            }
            else if (quantity >= 20)
            {
                discount = 0.15;
            }
            else if (quantity >= 10)
            {
                discount = 0.05;
            }

            double discountedPrice = totalPrice - (totalPrice * discount);

            switch (season)
            {
                case "Winter":
                    switch (type)
                    {
                        case "boys":
                            sport = "Judo";
                            break;
                        case "girls":
                            sport = "Gymnastics";
                            break;
                        case "mixed":
                            sport = "Ski";
                            break;
                    }
                    break;
                case "Spring":
                    switch (type)
                    {
                        case "boys":
                            sport = "Tennis";
                            break;
                        case "girls":
                            sport = "Athletics";
                            break;
                        case "mixed":
                            sport = "Cycling";
                            break;
                    }
                    break;
                case "Summer":
                    switch (type)
                    {
                        case "boys":
                            sport = "Football";
                            break;
                        case "girls":
                            sport = "Volleyball";
                            break;
                        case "mixed":
                            sport = "Swimming";
                            break;
                    }
                    break;
            }

            Console.WriteLine($"{sport} {discountedPrice:f2} lv.");
        }
    }
}

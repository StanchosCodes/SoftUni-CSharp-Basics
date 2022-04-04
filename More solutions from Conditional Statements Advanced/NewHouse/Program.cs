using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            const double rosePrice = 5;
            const double dahliaPrice = 3.80;
            const double tulipPrice = 2.80;
            const double narcisPrice = 3;
            const double gladiolaPrice = 2.50;

            double sum = 0;
            double discount = 0;

            switch (type)
            {
                case "Roses":
                    sum = quantity * rosePrice;
                    if (quantity > 80)
                    {
                        discount = sum * 0.10;
                    }
                    sum -= discount;
                    break;
                case "Dahlias":
                    sum = quantity * dahliaPrice;
                    if (quantity > 90)
                    {
                        discount = sum * 0.15;
                    }
                    sum -= discount;
                    break;
                case "Tulips":
                    sum = quantity * tulipPrice;
                    if (quantity > 80)
                    {
                        discount = sum * 0.15;
                    }
                    sum -= discount;
                    break;
                case "Narcissus":
                    sum = quantity * narcisPrice;
                    if (quantity < 120)
                    {
                        discount = sum * 0.15;
                    }
                    sum += discount;
                    break;
                case "Gladiolus":
                    sum = quantity * gladiolaPrice;
                    if (quantity < 80)
                    {
                        discount = sum * 0.20;
                    }
                    sum += discount;
                    break;
            }
            

            if (sum <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} {type} and {budget - sum:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {sum - budget:f2} leva more.");
            }
        }
    }
}

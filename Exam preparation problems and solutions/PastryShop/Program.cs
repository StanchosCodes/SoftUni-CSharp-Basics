using System;

namespace PastryShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int dayOfDecember = int.Parse(Console.ReadLine());

            double moneyForSweets = 0;

            switch (type)
            {
                case "Cake":
                    if (dayOfDecember <= 15)
                    {
                        moneyForSweets = quantity * 24;
                    }
                    else
                    {
                        moneyForSweets = quantity * 28.70;
                    }
                    break;
                case "Souffle":
                    if (dayOfDecember <= 15)
                    {
                        moneyForSweets = quantity * 6.66;
                    }
                    else
                    {
                        moneyForSweets = quantity * 9.80;
                    }
                    break;
                case "Baklava":
                    if (dayOfDecember <= 15)
                    {
                        moneyForSweets = quantity * 12.60;
                    }
                    else
                    {
                        moneyForSweets = quantity * 16.98;
                    }
                    break;
            }
            if (dayOfDecember <= 22)
            {
            if (moneyForSweets >= 100 && moneyForSweets <= 200)
            {
                moneyForSweets *= 0.85;
            }
            else if (moneyForSweets > 200)
            {
                moneyForSweets *= 0.75;
            }

            if (dayOfDecember <= 15)
            {
                moneyForSweets *= 0.90;
            }
            }

            Console.WriteLine($"{moneyForSweets:f2}");
        }
    }
}

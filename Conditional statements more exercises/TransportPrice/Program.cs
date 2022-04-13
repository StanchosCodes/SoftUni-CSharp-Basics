using System;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            double price = 0;

            if (km < 20)
            {
                price += 0.70;
                if (time == "day")
                {
                    price += 0.79 * km;
                }
                else
                {
                    price += 0.90 * km;
                }
            }
            else if (km >= 20 && km < 100)
            {
                price += 0.09 * km;
            }
            else
            {
                price += 0.06 * km;
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}

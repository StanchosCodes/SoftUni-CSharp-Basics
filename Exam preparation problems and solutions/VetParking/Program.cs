using System;

namespace VetParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hoursPerDay = int.Parse(Console.ReadLine());

            double totalTax = 0;

            for (int i = 1; i <= days; i++)
            {
                double tax = 0;

                for (int j = 1; j <= hoursPerDay; j++)
                {
                    if (i % 2 == 0 && j % 2 == 1)
                    {
                        tax += 2.50;
                    }
                    else if (i % 2 == 1 && j % 2 == 0)
                    {
                        tax += 1.25;
                    }
                    else
                    {
                        tax += 1;
                    }
                }
                totalTax += tax;
                Console.WriteLine($"Day: {i} - {tax:f2} leva");
            }
            Console.WriteLine($"Total: {totalTax:f2} leva");
        }
    }
}

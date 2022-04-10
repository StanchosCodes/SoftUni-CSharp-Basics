using System;

namespace ExcursionSale
{
    class Program
    {
        static void Main(string[] args)
        {
            int seaQuantity = int.Parse(Console.ReadLine());
            int mountainQuantity = int.Parse(Console.ReadLine());

            double sum = 0;
            int seaCounter = seaQuantity;
            int mountainCounter = mountainQuantity;

            const double seaPrice = 680;
            const double mountainPrice = 499;

            string input = Console.ReadLine();

            while (input != "Stop")
            {
                if (input == "sea" && seaCounter != 0)
                {
                    seaCounter--;
                    sum += seaPrice;
                }
                else if (input == "mountain" && mountainCounter != 0)
                {
                    mountainCounter--;
                    sum += mountainPrice;
                }
                if (seaCounter == 0 && mountainCounter == 0)
                {
                    break;
                }
                input = Console.ReadLine();
            }

            if (seaCounter == 0 && mountainCounter == 0)
            {
                Console.WriteLine("Good job! Everything is sold.");
            }
            Console.WriteLine($"Profit: {sum} leva.");
        }
    }
}

using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());

            double convertedChange = change * 100;
            int coins = (int)convertedChange;
            int coinsQuantity = 0;

            while (coins > 0)
            {
                if (coins - 200 >= 0)
                {
                    coinsQuantity++;
                    coins -= 200;
                }
                else if (coins - 100 >= 0)
                {
                    coinsQuantity++;
                    coins -= 100;
                }
                else if (coins - 50 >= 0)
                {
                    coinsQuantity++;
                    coins -= 50;
                }
                else if (coins - 20 >= 0)
                {
                    coinsQuantity++;
                    coins -= 20;
                }
                else if (coins - 10 >= 0)
                {
                    coinsQuantity++;
                    coins -= 10;
                }
                else if (coins - 5 >= 0)
                {
                    coinsQuantity++;
                    coins -= 5;
                }
                else if (coins - 2 >= 0)
                {
                    coinsQuantity++;
                    coins -= 2;
                }
                else if (coins - 1 >= 0)
                {
                    coinsQuantity++;
                    coins -= 1;
                }
            }
            Console.WriteLine(coinsQuantity);
        }
    }
}

using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolii = int.Parse(Console.ReadLine());
            int zumbuli = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactuses = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            const double magnoliiPrice = 3.25;
            const double zumbuliPrice = 4;
            const double rosesPrice = 3.50;
            const double cactusesPrice = 8;

            double sumPriceForOrder = (magnoliiPrice * magnolii) + (zumbuliPrice * zumbuli) + (rosesPrice * roses) + (cactusesPrice * cactuses);

            double totalMoney = sumPriceForOrder * 0.95;

            if (totalMoney >= giftPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(totalMoney - giftPrice)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice - totalMoney)} leva.");
            }


        }
    }
}

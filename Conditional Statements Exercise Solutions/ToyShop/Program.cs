using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            const double puzzlePrice = 2.60;
            const double talkingDollsPrice = 3;
            const double bearsPrice = 4.10;
            const double minionsPrice = 8.20;
            const double trucksPrice = 2;

            double tripPrice = double.Parse(Console.ReadLine());
            int puzzlesNum = int.Parse(Console.ReadLine());
            int talkingDollsNum = int.Parse(Console.ReadLine());
            int bearsNum = int.Parse(Console.ReadLine());
            int minionsNum = int.Parse(Console.ReadLine());
            int trucksNum = int.Parse(Console.ReadLine());

            int toysSum = puzzlesNum + talkingDollsNum + bearsNum + minionsNum + trucksNum;
            double toysSumPrice = (puzzlePrice * puzzlesNum) + (talkingDollsPrice * talkingDollsNum) + (bearsPrice * bearsNum) + (minionsPrice * minionsNum) + (trucksPrice * trucksNum);

            if (toysSum >= 50)
            {
                toysSumPrice *= 0.75;
            }

            toysSumPrice *= 0.90;
            double totalMoneyLeft = 0;
            
            if(toysSumPrice >= tripPrice)
            {
                totalMoneyLeft = toysSumPrice - tripPrice;
                Console.WriteLine($"Yes! {totalMoneyLeft:f2} lv left.");
            }
            else
            {
                totalMoneyLeft = tripPrice - toysSumPrice;
                Console.WriteLine($"Not enough money! {totalMoneyLeft:f2} lv needed.");
            }
        }
    }
}

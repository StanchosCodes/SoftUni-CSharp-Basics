using System;

namespace Excursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            int cards = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());

            const double nightsPrice = 20;
            const double cardsPrice = 1.60;
            const double ticketsPrice = 6;

            double moneyPerPerson = (nights * nightsPrice) + (cards * cardsPrice) + (tickets * ticketsPrice);
            double totalMoney = moneyPerPerson * people;
            double finalMoney = totalMoney * 1.25;

            Console.WriteLine($"{finalMoney:f2}");
        }
    }
}

using System;

namespace MovieProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfMovie = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            int percentage = int.Parse(Console.ReadLine());

            double daylyTicketsMoney = tickets * ticketPrice;
            double allPeriodMoney = daylyTicketsMoney * days;
            double moneyForTheCinema = allPeriodMoney * percentage / 100;
            double profit = allPeriodMoney - moneyForTheCinema;

            Console.WriteLine($"The profit from the movie {nameOfMovie} is {profit:f2} lv.");
        }
    }
}

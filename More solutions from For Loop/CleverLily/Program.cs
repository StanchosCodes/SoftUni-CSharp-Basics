using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washerPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int birthdayMoney = 0;
            int toys = 0;
            int evenYears = 0;

            for (int counter = 1; counter <= age; counter++)
            {
                if (counter % 2 == 0)
                {
                    evenYears++;
                    birthdayMoney += evenYears * 10;
                }
                else
                {
                    toys++;
                }
            }
            int moneyFromToys = toys * toyPrice;
            int totalMoney = birthdayMoney + moneyFromToys - evenYears;

            if (totalMoney >= washerPrice)
            {
                Console.WriteLine($"Yes! {totalMoney - washerPrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washerPrice - totalMoney:f2}");
            }
        }
    }
}

using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearTax = int.Parse(Console.ReadLine());
            double trainersPrice = yearTax * 0.6; //purvi nachin za izvajdane na pocenti
            double outfitPrice = trainersPrice - 0.2 * trainersPrice; //vtori nachin za izvajdane na procenti
            double ballPrice = outfitPrice / 4;
            double acsesoriesPrice = ballPrice / 5;
            double expenses = yearTax + trainersPrice + outfitPrice + ballPrice + acsesoriesPrice;
            Console.WriteLine(expenses);
        }
    }
}

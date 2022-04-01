using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int pencils = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int detergent = int.Parse(Console.ReadLine());
            int discountInPresentage = int.Parse(Console.ReadLine());

            double pensilsPrice = pencils * 5.80;
            double markersPrice = markers * 7.20;
            double detergentPrice = detergent * 1.20;
            double stockPrice = pensilsPrice + markersPrice + detergentPrice;

            double discount = discountInPresentage / 100.0;
            double discountedPrice = stockPrice - discount * stockPrice;
            Console.WriteLine(discountedPrice);
        }
    }
}

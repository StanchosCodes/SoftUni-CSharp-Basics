using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine();
            int nightCount = int.Parse(Console.ReadLine());

            double discountForStudio = 0;
            double discountForApartment = 0;
            double studioPrice = 0;
            double apartmentPrice = 0;

            if (mounth == "May" || mounth == "October")
            {
                studioPrice = 50 * nightCount;
                apartmentPrice = 65 * nightCount;
                if (nightCount > 14)
                {
                    discountForStudio = studioPrice * 0.30;
                    discountForApartment = apartmentPrice * 0.10;
                }
                else if (nightCount > 7)
                {
                    discountForStudio = studioPrice * 0.05;
                }
            }
            else if (mounth == "June" || mounth == "September")
            {
                studioPrice = 75.20 * nightCount;
                apartmentPrice = 68.70 * nightCount;
                if (nightCount > 14)
                {
                    discountForStudio = studioPrice * 0.20;
                    discountForApartment = apartmentPrice * 0.10;
                }
            }
            else
            {
                studioPrice = 76 * nightCount;
                apartmentPrice = 77 * nightCount;
                if (nightCount > 14)
                {
                    discountForApartment = apartmentPrice * 0.10;
                }
            }
            Console.WriteLine($"Apartment: {apartmentPrice - discountForApartment:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice - discountForStudio:f2} lv.");
        }
    }
}

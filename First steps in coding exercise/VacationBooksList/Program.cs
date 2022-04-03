using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int hoursForBook = pages / pagesPerHour;
            int hoursPerDay = hoursForBook / days;

            Console.WriteLine(hoursPerDay);
        }
    }
}

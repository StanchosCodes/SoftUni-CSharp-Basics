using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourOfTheExam = int.Parse(Console.ReadLine());
            int minuteOfTheExam = int.Parse(Console.ReadLine());
            int hourOfAriving = int.Parse(Console.ReadLine());
            int minuteOfAriving = int.Parse(Console.ReadLine());

            int difference = 0;
            int hours = 0;
            int minutes = 0;

            minuteOfTheExam += hourOfTheExam * 60;
            minuteOfAriving += hourOfAriving * 60;

            if (minuteOfAriving > minuteOfTheExam)
            {
                Console.WriteLine("Late");
                difference = minuteOfAriving - minuteOfTheExam;
                
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    hours = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hours}:{minutes:d2} hours after the start");
                }
            }
            else if (minuteOfAriving < minuteOfTheExam - 30)
            {
                Console.WriteLine("Early");
                difference = minuteOfTheExam - minuteOfAriving;

                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    hours = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hours}:{minutes:d2} hours before the start");
                }
            }
            else
            {
                Console.WriteLine("On time");
                difference = minuteOfTheExam - minuteOfAriving;
                Console.WriteLine($"{difference} minutes before the start");
            }
        }
    }
}

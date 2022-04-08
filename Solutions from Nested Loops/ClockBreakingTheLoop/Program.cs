using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            for (int hour = 0; hour <= 23; hour++)
            {
                for (int minutes = 0; minutes <= 59; minutes++)
                {
                    Console.WriteLine($"{hour:d2}:{minutes:d2}");

                    if (hour == 7 && minutes == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            Console.WriteLine("Wake up!");
        }
    }
}

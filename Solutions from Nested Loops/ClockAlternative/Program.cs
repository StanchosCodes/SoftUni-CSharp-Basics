using System;
using System.Threading; // библиотека на system

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hour = 0; hour <= 23; hour++)
            {
                for (int minutes = 0; minutes <= 59; minutes++)
                {
                    Thread.Sleep(1000); // кара нишката да заспи (паузира) за 1000 милисекунди и след това да продължи като for цикъла в случая е нишката
                    Console.WriteLine($"{hour:d2}:{minutes:d2}"); // d2 отпечатва променливите hour и minutes с двуцифрени числа в случаите когато те са едноцифрени като им добавя 0 отпред
                }
            }
        }
    }
}

using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            if (destination == "End")
            {
                return;
            }

            while (destination != "End")
            {
                double price = double.Parse(Console.ReadLine());
                double sumMoney = 0;

                while (sumMoney < price)
                {
                    double savedMoney = double.Parse(Console.ReadLine());
                    sumMoney += savedMoney;

                    if (sumMoney >= price)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        break;
                    }
                }
                destination = Console.ReadLine();
            }
        }
    }
}

using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());

            int spendingCounter = 0;
            int allOperationsCounter = 0;



            if (tripPrice <= currentMoney)
            {
                Console.WriteLine($"You saved the money for {allOperationsCounter}");
                return;
            }

            string operation = Console.ReadLine();

            while (currentMoney < tripPrice)
            {
                allOperationsCounter++;
                double operatingMoney = double.Parse(Console.ReadLine());

                if (operation == "save")
                {
                    spendingCounter = 0;
                    currentMoney += operatingMoney;
                    if (currentMoney >= tripPrice)
                    {
                        break;
                    }
                }
                else
                {
                    spendingCounter++;
                    if (currentMoney < operatingMoney)
                    {
                        currentMoney = 0;
                    }
                    else
                    {
                        currentMoney -= operatingMoney;
                    }

                    if (spendingCounter == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(allOperationsCounter);
                        return;
                    }
                }
                operation = Console.ReadLine();
            }
            Console.WriteLine($"You saved the money for {allOperationsCounter} days.");
        }
    }
}

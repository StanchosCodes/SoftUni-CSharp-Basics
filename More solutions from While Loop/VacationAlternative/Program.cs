using System;

namespace VacationAlternative
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());

            int spendingCounter = 0;
            int allOperationsCounter = 0;

            while (spendingCounter != 5)
            {
                string operation = Console.ReadLine();
                double operatingMoney = double.Parse(Console.ReadLine());
                allOperationsCounter++;

                if (operation == "save")
                {
                    currentMoney += operatingMoney;
                    spendingCounter = 0;
                }
                else if (operation == "spend")
                {
                    spendingCounter++;
                    if (operatingMoney > currentMoney)
                    {
                        currentMoney = 0;
                    }
                    else
                    {
                        currentMoney -= operatingMoney;
                    }
                }
                if (currentMoney >= tripPrice)
                {
                    Console.WriteLine($"You saved the money for {allOperationsCounter} days.");
                    break;
                }
            }
            if (spendingCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(allOperationsCounter);
            }
        }
    }
}

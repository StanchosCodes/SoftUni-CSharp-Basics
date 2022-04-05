using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int counter = 1; counter <= tabs; counter++)
            {
                string tabsTitles = Console.ReadLine();
                
                switch (tabsTitles)
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
                if (counter == tabs && salary != 0)
                    {
                        Console.WriteLine(salary);
                    }
            }
        }
    }
}

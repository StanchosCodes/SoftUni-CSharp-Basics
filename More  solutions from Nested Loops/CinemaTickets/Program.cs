using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int allTicketsCount = 0;
            int allStudentTicketsCount = 0;
            int allNormalTicketsCount = 0;
            int allKidsTicketscount = 0;
            bool isFinished = false;

            while (name != "Finish")
            {
                int freeSpace = int.Parse(Console.ReadLine());

                int studentTicketsCount = 0;
                int normalTicketsCount = 0;
                int kidsTicketsCount = 0;


                while (studentTicketsCount + normalTicketsCount + kidsTicketsCount < freeSpace)
                {
                    string typeOfTicket = Console.ReadLine();
                    if (typeOfTicket == "Finish")
                    {
                        isFinished = true;
                        break;
                    }

                    if (typeOfTicket != "End")
                    {
                        allTicketsCount++;

                        switch (typeOfTicket)
                        {
                            case "student":
                                allStudentTicketsCount++;
                                studentTicketsCount++;
                                break;
                            case "standard":
                                allNormalTicketsCount++;
                                normalTicketsCount++;
                                break;
                            case "kid":
                                allKidsTicketscount++;
                                kidsTicketsCount++;
                                break;
                        }
                    }
                    else
                    {
                        break;
                    }
                    if (studentTicketsCount + normalTicketsCount + kidsTicketsCount > freeSpace)
                    {
                        break;
                    }
                }
                Console.WriteLine($"{name} - {(studentTicketsCount + normalTicketsCount + kidsTicketsCount) / (double)freeSpace * 100:f2}% full.");
                if (isFinished)
                {
                    break;
                }
                name = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {allTicketsCount}");
            Console.WriteLine($"{allStudentTicketsCount / (double)allTicketsCount * 100:f2}% student tickets.");
            Console.WriteLine($"{allNormalTicketsCount / (double)allTicketsCount * 100:f2}% standard tickets.");
            Console.WriteLine($"{allKidsTicketscount / (double)allTicketsCount * 100:f2}% kids tickets.");
        }
    }
}

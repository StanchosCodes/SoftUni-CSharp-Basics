using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            int sumPeople = 0;
            double group1 = 0;
            double group2 = 0;
            double group3 = 0;
            double group4 = 0;
            double group5 = 0;

            for (int counter = 0; counter < groups; counter++)
            {
                int people = int.Parse(Console.ReadLine());
                sumPeople += people;

                if (people <= 5)
                {
                    group1 += people;
                }
                else if (people <= 12)
                {
                    group2 += people;
                }
                else if (people <= 25)
                {
                    group3 += people;
                }
                else if (people <= 40)
                {
                    group4 += people;
                }
                else if (people > 40)
                {
                    group5 += people;
                }
            }
            Console.WriteLine($"{group1 / sumPeople * 100:f2}%");
            Console.WriteLine($"{group2 / sumPeople * 100:f2}%");
            Console.WriteLine($"{group3 / sumPeople * 100:f2}%");
            Console.WriteLine($"{group4 / sumPeople * 100:f2}%");
            Console.WriteLine($"{group5 / sumPeople * 100:f2}%");
        }
    }
}

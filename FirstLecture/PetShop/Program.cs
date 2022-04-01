using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CAT = 4;
            const double DOG = 2.50;
            int numDogs = int.Parse(Console.ReadLine());
            int numCats = int.Parse(Console.ReadLine());
            double sumDogs = numDogs * DOG;
            int sumCats = numCats * CAT;
            double sum = sumDogs + sumCats;
            Console.WriteLine(sum + " lv.");

        }
    }
}

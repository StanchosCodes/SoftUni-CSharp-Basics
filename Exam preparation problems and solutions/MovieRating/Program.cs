using System;

namespace MovieRating
{
    class Program
    {
        static void Main(string[] args)
        {
            int moviesQuantity = int.Parse(Console.ReadLine());

            double maxRatedMovie = 0;
            double minRatedMovie = double.MaxValue;
            string nameOfMaxRatedMovie = "";
            string nameOfMinRatedMOvie = "";
            double sumOfRates = 0;
            for (int i = 0; i < moviesQuantity; i++)
            {
                string nameOfCurrentMovie = Console.ReadLine();
                double rateOfCurrentMovie = double.Parse(Console.ReadLine());

                sumOfRates += rateOfCurrentMovie;

                if (rateOfCurrentMovie > maxRatedMovie)
                {
                    maxRatedMovie = rateOfCurrentMovie;
                    nameOfMaxRatedMovie = nameOfCurrentMovie;
                }
                if (rateOfCurrentMovie < minRatedMovie)
                {
                    minRatedMovie = rateOfCurrentMovie;
                    nameOfMinRatedMOvie = nameOfCurrentMovie;
                }
            }
            double averageRate = sumOfRates / moviesQuantity;

            Console.WriteLine($"{nameOfMaxRatedMovie} is with highest rating: {maxRatedMovie:f1}");
            Console.WriteLine($"{nameOfMinRatedMOvie} is with lowest rating: {minRatedMovie:f1}");
            Console.WriteLine($"Average rating: {averageRate:f1}");
        }
    }
}

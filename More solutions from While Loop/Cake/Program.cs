using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int currentCakeSizeInPieces = width * length;
            int currentPiecesTaken = 0;

            string currentPieces = Console.ReadLine();

            while (currentPieces != "STOP")
            {
                currentPiecesTaken = int.Parse(currentPieces);
                if (currentPiecesTaken >= currentCakeSizeInPieces)
                {
                    currentCakeSizeInPieces = currentPiecesTaken - currentCakeSizeInPieces;
                    break;
                }
                else
                {
                    currentCakeSizeInPieces -= currentPiecesTaken;
                }
                currentPieces = Console.ReadLine();
            }
            if (currentPieces == "STOP")
            {
                Console.WriteLine($"{currentCakeSizeInPieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {currentCakeSizeInPieces} pieces more.");
            }
        }
    }
}

using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());

            int space = width * length * hight;
            int boxes = 0;

            string input = Console.ReadLine();

            while (input != "Done")
            {
                boxes = int.Parse(input);
                if (space >= boxes)
                {
                    space -= boxes;
                }
                else
                {
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "Done")
            {
                Console.WriteLine($"{space} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(boxes - space)} Cubic meters more.");
            }
        }
    }
}

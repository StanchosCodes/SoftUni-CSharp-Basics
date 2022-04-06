using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string pass = Console.ReadLine();

            string inputPass = Console.ReadLine();

            while (inputPass != pass)
            {
                inputPass = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {username}!");
        }
    }
}

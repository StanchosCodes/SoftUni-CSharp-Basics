using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();

            string checkedBook = Console.ReadLine();

            int counter = 0;

            while (checkedBook != bookName)
            {
                if (checkedBook == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {counter} books.");
                    break;
                }
                counter++;
                checkedBook = Console.ReadLine();
            }
            if (checkedBook == bookName)
            {
            Console.WriteLine($"You checked {counter} books and found it.");
            }
        }
    }
}

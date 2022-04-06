using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            int minNum = int.MaxValue;

            while (num != "Stop")
            {
                int convertedNum = int.Parse(num);
                while (minNum > convertedNum)
                {
                    minNum = convertedNum;
                }
                num = Console.ReadLine();
            }
            Console.WriteLine(minNum);
        }
    }
}

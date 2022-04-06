using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            int maxNum = int.MinValue;

            while (num != "Stop")
            {
                int convertedNum = int.Parse(num);
                while (maxNum < convertedNum)
                {
                    maxNum = convertedNum;
                }
                num = Console.ReadLine();
            }
            Console.WriteLine(maxNum);
        }
    }
}

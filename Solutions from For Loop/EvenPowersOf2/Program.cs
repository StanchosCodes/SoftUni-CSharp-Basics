using System;

namespace EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int power = 0; power <= n; power += 2)
            {
                Console.WriteLine(Math.Pow(2, power));
                // може и с променлива num, която ще държи резултата и ще умножаваме num по 2 и по 2 ( num = num * 2 * 2), което ще умножава само по четните стойности защото първо num = 0 после е num = 1 * 2 * 2 = 4; 4 * 2 * 2 = 16; и така е умножено само по четните стойности
                // или с if проверка дали числото е четно при всяка итерация и така пак ще умножаваме само по четните
            }
        }
    }
}

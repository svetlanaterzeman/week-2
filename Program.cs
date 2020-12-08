using System;

namespace Задание_17_из_ЕГЭ
{
    class Задание2    {
        static void Main(string[] args)
        {
            int counter = 0;
            int max = 0;
            for (int i = 1578; i < 6238; i++)
            {
                if ((i % 4 == 0) && (i % 3 != 0) && (i % 16 != 0) && (i % 12 != 0) && (i % 8 != 0))
                {
                    counter++;
                    max = i;
                }
            }
            Console.WriteLine(counter);
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}

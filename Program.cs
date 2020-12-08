using System;

namespace Задание_17_из_ЕГЭ
{
    class Задание1    {
        static void Main(string[] args)
        {
            int counter = 0;
            int max = 0;
            for (int i = 2077; i < 8277; i++)
            {
                if ((i % 6 == 0) && (i % 4 != 0) && (i % 9 != 0) && (i % 20 != 0) && (i % 36 != 0))
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

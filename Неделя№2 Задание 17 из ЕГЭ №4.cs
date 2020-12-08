using System;

namespace Задание_17_из_ЕГЭ
{
    class Задание4    {
        static void Main(string[] args)
        {
            int counter = 0;
            int max = 0;
            for (int i = 10000; i < 100001; i++)
            {
                if ((i % 23 == 0) && (i % 5 != 0) && (i % 6 != 0) && (i % 7 != 0) && (i % 8 != 0))
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

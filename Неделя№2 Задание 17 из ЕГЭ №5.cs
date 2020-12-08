using System;

namespace Задание_17_из_ЕГЭ
{
    class Задание5    {
        static void Main(string[] args)
        {
            int counter = 0;
            int max = 0;
            for (int i = 29384; i < 48494; i++)
            {
                if ((i % 78 == 0) && (i % 7 != 0) && (i % 8 != 0) && (i % 12 != 0) && (i % 80 != 0))
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

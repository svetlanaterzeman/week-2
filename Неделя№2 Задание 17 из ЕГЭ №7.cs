using System;

namespace Задание_17_из_ЕГЭ
{
    class Задание7    {
        static void Main(string[] args)
        {
            int max = 0;
            int predmax = 0;
            for (int i = 2765; i < 9526; i++)
            {
                if ((i % 205 == 0) && (i % 10 != 0) && (i % 16 != 0) && (i % 82 != 0))
                {
                    predmax = max;
                    max = i;
                }
            }
            Console.WriteLine(predmax);
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}

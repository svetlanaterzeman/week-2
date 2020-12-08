using System;

namespace Задание_17_из_ЕГЭ
{
    class Задание3    {
        static void Main(string[] args)
        {
            int counter = 0;
            int max = 0;
            for (int i = 9013; i < 23801; i++)
            {
                if ((i % 9 == 0) && (i % 2 != 0) && (i % 6 != 0) && (i % 12 != 0) && (i % 81 != 0))
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

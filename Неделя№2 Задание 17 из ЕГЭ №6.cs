using System;

namespace Задание_17_из_ЕГЭ
{
    class Задание6    {
        static void Main(string[] args)
        {
            int counter = 0;
            int max = 0;
            for (int i = 1234; i < 8766; i++)
            {
                if ((i % 27 == 0) && (i % 4 != 0) && (i % 72 != 0) && (i % 81 != 0) && (i % 128 != 0))
                {
                    counter++;
                    if((i%7==3)&&(i>max))
                    {
                        max = i;
                    }
                }
            }
            Console.WriteLine(counter);
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}

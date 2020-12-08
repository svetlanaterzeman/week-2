using System;

namespace Задание_17_из_ЕГЭ
{
    class Задание8    {
        static void Main(string[] args)
        {
            int n1;
            int max = 0;
            int counter = 0;
            for (int i = 1568; i < 9957; i++)
            {
                n1=(int)(Math.Pow(i, 0.5));
                if((n1*n1==i)&&(i%9!=0)&&(i%25!=0))
                {
                    max = i;
                        counter++;
                }
            }
            Console.WriteLine(counter);
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}

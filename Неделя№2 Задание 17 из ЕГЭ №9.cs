using System;

namespace Задание_17_из_ЕГЭ
{
    class Задание9   {
        static void Main(string[] args)
        {
            int counter = 0;
            int min = 1000000000;
            for (int i = 3578; i < 8010; i++)
            {
                if((i%17==0)&&(i%93!=0)&&(i%100==11))
                {   
                    if(min>i)
                    {
                        min = i;
                    }
                    counter++;
                }
            }
            Console.WriteLine(counter);
            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}

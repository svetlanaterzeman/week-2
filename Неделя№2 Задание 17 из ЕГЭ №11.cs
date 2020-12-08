using System;

namespace Задание_17_из_ЕГЭ
{
    class Задание11   {
        static void Main(string[] args)
        {
            int counter = 0;
            int max = 0;
            for (int i = 73; i < 5579; i++)
            {
                if(157080%i==0)
                {
                    counter++;
                    if(i%10==0)
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

using System;

namespace Задание_17_из_ЕГЭ
{
    class Задание10   {
        static void Main(string[] args)
        {
            int counter = 0;
            int max = 0;
            for (int i = 3578; i < 8010; i++)
            {
                bool flag = true;
                for (int j=2; j<i/2+1; j++)
                {
                    if(i%j==0)
                    {
                        flag = false;
                    }
                }
                if(flag==true)
                {
                    counter++;
                    if(i%10==7)
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

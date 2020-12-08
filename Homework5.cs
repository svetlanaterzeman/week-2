using System;

namespace Homework5
{
    class Program   {
        static void Main(string[] args)
        {
            string A, B, C;
            Console.WriteLine("Введите коэффициент A");
            A = Console.ReadLine();
            if (float.TryParse(A, out float a))
            {
                a = Convert.ToSingle(A);
                Console.WriteLine("Введите коэффициент B");
                B = Console.ReadLine();
                if (float.TryParse(B, out float b))
                {
                    b = Convert.ToSingle(B);
                    Console.WriteLine("Введите коэффициент C");
                    C = Console.ReadLine();
                    if (float.TryParse(C, out float c))
                    {
                        c = Convert.ToSingle(C);
                        var discriminant = (b * b) - (4 * a * c);
                        if (discriminant > 0)
                        {
                            var t1 = ((-1 * b) + (Math.Pow(discriminant, 0.5))) / (2 * a);
                            var t2 = ((-1 * b) - (Math.Pow(discriminant, 0.5))) / (2 * a);
                            if(t2<0)
                            {
                                if (t1 == 0)
                                {
                                    var x1 = Math.Pow(t1, 0.5);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(x1);
                                }
                                if (t1 > 0)
                                {
                                    var x1 = Math.Pow(t1, 0.5);
                                    var x2 = -1 * (Math.Pow(t1, 0.5));
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(x1);
                                    Console.WriteLine(x2);
                                }
                                if (t1 < 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Нет корней");
                                }
                            }
                            if(t2==0)
                            {
                                if (t1 == 0)
                                {
                                    var x1 = Math.Pow(t1, 0.5);
                                    var x3 = Math.Pow(t2, 0.5);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(x1);
                                    Console.WriteLine(x3);
                                }
                                if (t1 > 0)
                                {
                                    var x1 = Math.Pow(t1, 0.5);
                                    var x2 = -1 * (Math.Pow(t1, 0.5));
                                    var x3 = Math.Pow(t2, 0.5);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(x1);
                                    Console.WriteLine(x2);
                                    Console.WriteLine(x3);
                                }
                                if (t1 < 0)
                                {
                                    var x3 = Math.Pow(t2, 0.5);
                                    Console.WriteLine(x3);
                                }
                            }
                            if(t2>0)
                            {
                                if (t1 == 0)
                                {
                                    var x1 = Math.Pow(t1, 0.5);
                                    var x3 = Math.Pow(t2, 0.5);
                                    var x4 = -1 * (Math.Pow(t2, 0.5));
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(x1);
                                    Console.WriteLine(x3);
                                    Console.WriteLine(x4);
                                }
                                if (t1 > 0)
                                {
                                    var x1 = Math.Pow(t1, 0.5);
                                    var x2 = -1 * (Math.Pow(t1, 0.5));
                                    var x3 = Math.Pow(t2, 0.5);
                                    var x4 = -1 * (Math.Pow(t2, 0.5));
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(x1);
                                    Console.WriteLine(x2);
                                    Console.WriteLine(x3);
                                    Console.WriteLine(x4);
                                }
                                if (t1 < 0)
                                {
                                    var x3 = Math.Pow(t2, 0.5);
                                    var x4 = -1 * (Math.Pow(t2, 0.5));
                                    Console.WriteLine(x3);
                                    Console.WriteLine(x4);
                                }
                            }
                        }
                        if (discriminant == 0)
                        {
                            var t = (-1 * b) / (2 * a);
                            if(t==0)
                            {
                                var x1 = Math.Pow(t, 0.5);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(x1);
                            }
                            if(t>0)
                            {
                                var x1 = Math.Pow(t, 0.5);
                                var x2 = -1 * (Math.Pow(t, 0.5));
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(x1);
                                Console.WriteLine(x2);
                            }
                            if(t<0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Нет корней");
                            }
                            
                        }
                        if (discriminant < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Нет корней");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Данные введены некорректно.Введите коофициент повторно");
                    }
                }
                else
                {
                    Console.WriteLine("Данные введены некорректно.Введите коофициент повторно");
                } 
            }
            else
            {
                Console.WriteLine("Данные введены некорректно.Введите коофициент повторно");
            }
            

        }
    }
}

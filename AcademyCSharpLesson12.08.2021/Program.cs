using System;

namespace AcademyCSharpLesson12._08._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1
            /*Console.WriteLine("Программа 1\n");
            Console.WriteLine("Введите Два числа по очереди чтобы получить сумму и нечётные числа!");
            Console.WriteLine("Введите первое число");
            int.TryParse(Console.ReadLine(), out var A);
            Console.WriteLine("Введите второе число");
            int.TryParse(Console.ReadLine(), out var B);
            var result = 0;
            for (int i = A; i < B; i++)
            {
                if (i == A)
                {
                    continue;
                }
                else
                {
                    result += i;
                }
                if (i % 2 != 0)
                {
                    Console.WriteLine("Не чётное число {0}", i);
                }
            }
            Console.Write("\n");
            Console.WriteLine("Result of sum = {0}", result);
            Console.Write('\n');*/



            // Problem 2 
            Console.WriteLine("Программа 2\n");

            Console.WriteLine("Прямоугольник #1");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (i != 0 && i != 5)
                    {
                        if (j > 0 && j < 19)
                        {
                            Console.Write(' ');
                            continue;
                        }
                        else
                            Console.Write('*');
                    }
                    else
                    {
                        Console.Write('*');

                    }
                }
                Console.Write('\n');
            }
            Console.Write('\n');
            Console.WriteLine("Прямоугольник #2 с пробелами");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (i == 0 || i == 5)
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write(' ');
                            continue;
                        }
                        else
                            Console.Write('*');

                    }
                    else if (i != 0 && i != 5)
                    {
                        if (j > 0 && j < 18)
                        {
                            Console.Write(' ');
                            continue;
                        }
                        else if (j == 19)
                        {
                            continue;
                        }
                        else
                            Console.Write('*');
                    }
                    else
                    {
                        Console.Write('*');

                    }
                }
                Console.Write('\n');
            }
            Console.Write('\n');

            Console.WriteLine("Прямоугольный треугольник");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        Console.Write('*');
                    }
                    if (i == 9)
                    {
                        if (j == 9)
                        {
                            break;
                        }
                        Console.Write('*');
                    }
                    else
                        Console.Write(' ');
                }
                Console.Write('\n');
            }
            Console.Write('\n');

            Console.WriteLine("Прямоугольный треугольник #2 с пробелами");
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        Console.Write('*');
                    }
                    if (i == 10)
                    {
                        if (j == 10)
                        {
                            break;
                        }
                        else if (j % 2 != 0)
                        {
                            Console.Write(' ');
                            continue;
                        }
                        Console.Write('*');
                    }
                    else
                        Console.Write(' ');
                }
                Console.Write('\n');
            }
            Console.Write('\n');

            Console.WriteLine("Равносторонний треугольник");
            int hor, gor, heightt = 15;
            for (hor = 0; hor < heightt; hor++)
            {

                for (gor = heightt - hor; gor > 0; gor--)
                    Console.Write(" ");

                for (gor = 0; gor <= 2 * hor; gor++)
                {
                    if (gor < 2 * hor && gor > 0 && hor != (heightt - 1))
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Write('\n');


            Console.WriteLine("Равносторонний треугольник #2 с пробелами");
            int hor1, gor1, heightt1 = 15;
            for (hor1 = 0; hor1 < heightt1; hor1++)
            {
                var countable = 0;
                for (gor1 = heightt1 - hor1; gor1 > 0; gor1--)
                    Console.Write(" ");

                for (gor1 = 0; gor1 <= 2 * hor1; gor1++)
                {
                    if (gor1 < 2 * hor1 && gor1 > 0 && hor1 != (heightt1 - 1))
                        Console.Write(" ");
                    else
                    {
                        if (hor1 == 14 && gor1 >= 1 && heightt1 == 15)
                        {
                            if (countable > 16)
                            {
                                break;
                            }
                            else if (hor1 == 14 && gor1 >= 15 && heightt1 == 15)
                            {
                                break;
                            }
                            else
                            {
                                Console.Write(" *");
                                countable++;
                            }
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.Write('\n');

            Console.WriteLine("Ромб");
            var Height = 15;
            Height = Height % 2 == 0 ? Height + 1 : Height;
            Console.WriteLine("{0}{1}", new string(' ', Height / 2), '*');
            for (var i = 1; i < Height - 1; i++)
            {
                var spacesOutSide = Math.Abs(Height / 2 - i);
                var spacesInSide = Height - 2 * spacesOutSide - 2;
                Console.WriteLine("{0}{1}{2}{1}", new string(' ', spacesOutSide), '*', new string(' ', spacesInSide));
            }
            Console.WriteLine("{0}{1}", new string(' ', Height / 2), '*');
            Console.Write('\n');



            // Problem 3
            Console.WriteLine("Программа 3\n");
            Console.WriteLine("Начальный вклад в банке равен 1000 руб.");
            double procent;
            Console.WriteLine("Введите процент по вкладу(P > 0 и P < 25), от 0 до 25 :");
            procent = Convert.ToDouble(Console.ReadLine());
            if (procent < 0 || procent > 25)
            {
                Console.WriteLine("Недействительные процент вклада:)");
                Console.ReadKey();
            }
            int count = 0;
            double deposit;
            for (deposit = 1000; deposit < 1100; count++)
            {
                deposit += deposit * procent / 100;
            }
            Console.WriteLine("До того как лимит вклада на сумму 1100р. понадобится: {0} месяца \n сумма вклада будет: {1} руб.", count, deposit);
        }
    }
}

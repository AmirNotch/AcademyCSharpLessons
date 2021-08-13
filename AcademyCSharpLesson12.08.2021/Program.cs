using System;

namespace AcademyCSharpLesson12._08._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1
            Console.WriteLine("Программа 1\n");
            Console.WriteLine("Введите Два числа по очереди чтобы получить сумму и нечётные числа!");
            int.TryParse(Console.ReadLine(), out var A);
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
            Console.Write('\n');

            // Problem 2 
            Console.WriteLine("Программа 2\n");

            Console.WriteLine("Прямоугольник");
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

            Console.WriteLine("Прямоугольный треугольник");
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        Console.Write('*');
                    }
                    if (i == 19)
                    {
                        if (j == 19)
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
            int procent = 25;
            var resulted = 0;
            for (int i = 1; i < procent; i++)
            {
                resulted = (i * 1000) / 100;
                if (resulted <= 100)
                {
                    Console.WriteLine("Размер вклада {0} месяц {1}, {2}%", (i * 1000) / 100 + (1000), i, resulted / 10);
                }
                else
                {
                    Console.Write('\n');
                    Console.WriteLine("Размер вклада превысил 1100 и достиг {0} за {1} месяцев, {2}%", resulted + 1000, i, resulted / 10);
                    break;
                }
                resulted = (i * 1000) / 100;
            }
        }
    }
}

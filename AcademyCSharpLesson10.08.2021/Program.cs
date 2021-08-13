using System;

namespace AcademyCSharpLesson10._08._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1
            Console.WriteLine("Программа #1 \n");
            Console.WriteLine("На какую сумму вы хотите совершить покупку?");
            Console.WriteLine("Введите число");
            var sum = Convert.ToInt32(Console.ReadLine());
            if (sum > 500 && sum <= 1000)
            {
                Console.WriteLine("Ваша скидка составляет 3%, вы согласны оплатить?");
                Console.WriteLine("Если согласны то напишите \"yes\", либо \"no\"");
                var answer = Console.ReadLine();
                if (answer == "yes")
                {
                    var discount = (sum * 3) / 100;
                    Console.WriteLine($"Общая цена с учётом скидки 3% составляет {sum - discount} сомони");
                    Console.WriteLine("Если согласны оплатить то напишите \"yes\", либо \"no\" если несогласны");
                    answer = Console.ReadLine();
                    if (answer == "yes")
                    {
                        Console.WriteLine("Удачи!");
                    }
                    else
                    {
                        Console.WriteLine("Вы отказались от покупки.");
                    }
                }
                else if (answer == "no")
                {
                    Console.WriteLine("Вы отказались от покупки.");
                }
            }
            else if (sum > 1000)
            {
                Console.WriteLine("Ваша скидка составляет 5%, вы согласны оплатить?");
                Console.WriteLine("Если согласны то напишите \"yes\", либо \"no\"");
                var answer = Console.ReadLine();
                if (answer == "yes")
                {
                    var discount = (sum * 5) / 100;
                    Console.WriteLine($"Общая цена с учётом скидки 5% составляет { sum - discount} сомони");
                    Console.WriteLine("Если согласны оплатить то напишите \"yes\", либо \"no\" если несогласны");
                    answer = Console.ReadLine();
                    if (answer == "yes")
                    {
                        Console.WriteLine("Удачи!");
                    }
                    else
                    {
                        Console.WriteLine("Вы отказались от покупки.");
                    }
                }
                else if (answer == "no")
                {
                    Console.WriteLine("Вы отказались от покупки.");
                }
            }
            else
            {
                Console.WriteLine("Сумма не привысила отметки 500 сомони, скидки не будет!");
            }

            // Problem 2 
            Console.WriteLine("Программа #2 \n");

            int a, b, c, d;
            a = 10;
            b = 10;
            c = 10;
            d = 10;

            if (a < b)
            {
                if (b < c)
                {
                    if (c < d)
                    {
                        Console.WriteLine("Числа расположены по возрастанию.");
                    }
                }
            }
            else if (a < b && a < c && a < d)
            {
                Console.WriteLine($"Самый минимальный {a}");
            }
            else if (b < a && b < c && b < d)
            {
                Console.WriteLine($"Самый минимальный {b}");
            }
            else if (c < a && c < b && c < d)
            {
                Console.WriteLine($"Самый минимальный {c}");
            }
            else if (d < a && d < b && d < c)
            {
                Console.WriteLine($"Самый минимальный {d}");
            }
            else if (d == a && d == b && d == c)
            {
                Console.WriteLine($"Их произведение {a * b * c * d}");
            }

            // Problem 3
            Console.WriteLine("Программа #3 \n");

            var num1 = 10; //Convert.ToInt32(Console.ReadLine());
            var num2 = 20; //Convert.ToInt32(Console.ReadLine());
            var num3 = 30; //Convert.ToInt32(Console.ReadLine());
            var result = 0;
            if (num2 >= num1)
            {
                num1 += num2;
                result = num2 -= num1;
                result = Math.Abs(result);
                num2 = result;
                num1 -= num2;

                if (num3 >= num1)
                {
                    num1 += num3;
                    result = num3 -= num1;
                    result = Math.Abs(result);
                    num3 = result;
                    num1 -= num3;

                    if (num3 >= num2)
                    {
                        num2 += num3;
                        result = num3 -= num2;
                        result = Math.Abs(result);
                        num3 = result;
                        num2 -= num3;

                        Console.WriteLine($"{num1} >= {num2} >= {num3}");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} >= {num2} >= {num3}");
                    }
                }
                else
                {
                    if (num2 >= num3)
                    {
                        Console.WriteLine($"{num1} >= {num2} >= {num3}");
                    }
                    else
                    {
                        num2 += num3;
                        result = num3 -= num2;
                        result = Math.Abs(result);
                        num3 = result;
                        num2 -= num3;

                        Console.WriteLine($"{num1} >= {num2} >= {num3}");

                    }
                }
            }
            else if (num3 >= num1)
            {
                num1 += num3;
                result = num3 -= num1;
                result = Math.Abs(result);
                num3 = result;
                num1 -= num3;

                if (num2 >= num1)
                {
                    num1 += num3;
                    result = num3 -= num1;
                    result = Math.Abs(result);
                    num3 = result;
                    num1 -= num3;

                    Console.WriteLine($"{num1} >= {num2} >= {num3}");
                }
                else
                {
                    num2 += num3;
                    result = num3 -= num2;
                    result = Math.Abs(result);
                    num3 = result;
                    num2 -= num3;
                    Console.WriteLine($"{num1} >= {num2} >= {num3}");
                }
            }
            else
            {
                Console.WriteLine($"{num1} >= {num2} >= {num3}");
            }
        }
    }
}

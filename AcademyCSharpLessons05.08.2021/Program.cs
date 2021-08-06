using System;

namespace AcademyCSharpLessons05._08._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1
            Console.WriteLine("Программа #1 \n");
            Console.WriteLine("Введите число А и В");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            if (A == B)
            {
                A = 0;
                B = 0;
                Console.WriteLine($"A = B: A={A} B={B}");
            }
            else
            {
                A++;
                B++;
                Console.WriteLine($"A != B: A={A} B={B}");

            }

            //Problem 2
            Console.WriteLine("Программа #2 \n");
            for (int i = 0; i < 1;)
            {
                Console.WriteLine("Вы согласны чтобы программа сама сгенерировала числа?");
                Console.WriteLine("Если согласны то напишите \"yes\", либо \"no\" если хотите задать числа сами, если хотите завершить программу напишите \"exit\"");
                String answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Random random = new Random();
                    int operand1 = random.Next(10, 100);
                    int operand2 = random.Next(1, 10);

                    Console.WriteLine("Выберите один из знаков арифметической операции, *,/,+,-,%,^, если хотите завершить программу напишите \"exit\"");
                    string sign = Console.ReadLine();
                    switch (sign)
                    {
                        case "*":
                            Console.WriteLine($"operand1 * operand2 = {operand1 * operand2}");
                            break;
                        case "/":
                            if (operand1 == 0 || operand2 == 0)
                            {
                                Console.WriteLine("На ноль Делить нельзя");
                                Console.WriteLine("Попробуйте ещё раз.\n");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine($"operand1 / operand2 = {operand1 / operand2}");
                                i = 1;
                            }
                            break;
                        case "+":
                            Console.WriteLine($"operand1 + operand2 = {operand1 + operand2}");
                            i = 1;
                            break;
                        case "-":
                            Console.WriteLine($"operand1 - operand2 = {operand1 - operand2}");
                            i = 1;
                            break;
                        case "%":
                            if (operand1 == 0 || operand2 == 0)
                            {
                                Console.WriteLine("Одно и чисел равно 0");
                                Console.WriteLine("Попробуйте ещё раз.");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine($"operand1 % operand2 = {operand1 % operand2}");
                                i = 1;
                            }
                            break;
                        case "^":
                            Console.WriteLine("Что будете возводить степень A в В или В в А");
                            Console.WriteLine("Ответьте А или В");
                            string answer2 = Console.ReadLine();
                            if (answer2 == "A")
                            {
                                Console.WriteLine("Ответ " + Math.Pow(A, B));
                                i = 1;
                            }
                            else if (answer2 == "B")
                            {
                                Console.WriteLine("Ответ " + Math.Pow(B, A));
                                i = 1;
                            }
                            break;

                        case "exit":
                            Console.WriteLine("Программа завершилась\n");
                            i = 1;
                            break;

                        default:
                            Console.WriteLine("Вы ввели не тот знак. Попробуйте снова.");
                            break;
                    }

                }
                else if (answer == "no")
                {
                    Console.WriteLine("Введите два числа по очереди");
                    int operand1 = Convert.ToInt32(Console.ReadLine());
                    int operand2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Выберите один из знаков арифметической операции, *,/,+,-,%,^, если хотите завершить программу напишите \"exit\"");
                    string sign = Console.ReadLine();

                    switch (sign)
                    {
                        case "*":
                            Console.WriteLine($"operand1 * operand2 = {operand1 * operand2}");
                            break;
                        case "/":
                            if (operand1 == 0 || operand2 == 0)
                            {
                                Console.WriteLine("На ноль Делить нельзя");
                                Console.WriteLine("Попробуйте ещё раз.");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine($"operand1 / operand2 = {operand1 / operand2}");
                                i = 1;
                            }
                            break;
                        case "+":
                            Console.WriteLine($"operand1 + operand2 = {operand1 + operand2}");
                            i = 1;
                            break;
                        case "-":
                            Console.WriteLine($"operand1 - operand2 = {operand1 - operand2}");
                            i = 1;
                            break;
                        case "%":
                            if (operand1 == 0 || operand2 == 0)
                            {
                                Console.WriteLine("Одно и чисел равно 0");
                                Console.WriteLine("Попробуйте ещё раз.");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine($"operand1 % operand2 = {operand1 % operand2}");
                                i = 1;
                            }
                            break;
                        case "^":
                            Console.WriteLine("Что будете возводить степень A в В или В в А");
                            Console.WriteLine("Ответьте А или В");
                            string answer2 = Console.ReadLine();
                            if (answer2 == "A")
                            {
                                Console.WriteLine("Ответ " + Math.Pow(A, B));
                                i = 1;
                            }
                            else if (answer2 == "B")
                            {
                                Console.WriteLine("Ответ " + Math.Pow(B, A));
                                i = 1;
                            }
                            break;
                        case "exit":
                            Console.WriteLine("Программа завершилась");
                            i = 1;
                            break;
                        default:
                            Console.WriteLine("Вы ввели не тот знак. Попробуйте снова.");
                            break;
                    }
                }
                else if (answer == "exit")
                {
                    Console.WriteLine("Программа завершилась");
                    i = 1;
                }
                else
                {
                    Console.WriteLine("Пожалуйста введите слово \"yes\", либо \"no\".");
                }
            }


            // Problem 3
            Console.WriteLine("Программа #3 \n");
            
            for (int i = 0; i < 1;)
            {
                Console.WriteLine("Введите число от 0 до 100");
                int number = int.Parse(Console.ReadLine());
                string range = number >= 0 && number <= 14 ? "|0 - 14| Промежуток" : number >= 15 && number <= 35 ? "|15 - 35| Промежуток" :
                number >= 36 && number <= 50 ? "|36 - 50| Промежуток" : number >= 50 && number <= 100 ? "|50 - 100| Промежуток" : "Вы ввели число не от 0 до 100";

                if (range == "Вы ввели число не от 0 до 100")
                {
                    Console.WriteLine("Пожалуйста введите число от 0 до 100 \n");
                }
                else
                {
                    Console.WriteLine(range);
                    i++;
                }
            }
        }
    }
}

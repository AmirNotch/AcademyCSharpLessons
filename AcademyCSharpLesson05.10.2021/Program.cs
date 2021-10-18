using System;

namespace AcademyCSharpLesson05._10._2021
{
    delegate T Operation<T, K>(K param1, K param2);
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Выберите первый параметр: ");
            double.TryParse(Console.ReadLine(), out var param1);
            Console.Write("Выберите второй параметр: ");
            double.TryParse(Console.ReadLine(), out var param2);
            bool working = true;
            Console.WriteLine("Выберите один из Алгебраических знаков (-, +, /, *)");
            while (working)
            {

                string symbol = Console.ReadLine();
                switch (symbol)
                {
                    case "+":
                        Operation<double, double> op1 = AlgebraicPlus;

                        Console.WriteLine(op1(param1, param2));
                        working = false;
                        break;
                    case "-":
                        Operation<double, double> op2 = AlgebraicMinus;

                        Console.WriteLine(op2(param1, param2));
                        working = false;
                        break;
                    case "*":
                        Operation<double, double> op3 = AlgebraicMyltyple;

                        Console.WriteLine(op3(param1, param2));
                        working = false;
                        break;
                    case "/":
                        Operation<double, double> op4 = AlgebraicDevide;

                        Console.WriteLine(op4(param1, param2));
                        working = false;
                        break;
                    default:
                        Console.WriteLine("выберите знак (-, +, /, *)");
                        break;
                }
            }
        }

        static double AlgebraicMyltyple(double param1, double param2)
        {
            return param1 * param2;
        }
        static double AlgebraicDevide(double param1, double param2)
        {
            return param1 / param2;
        }
        static double AlgebraicPlus(double param1, double param2)
        {
            return param1 + param2;
        }
        static double AlgebraicMinus(double param1, double param2)
        {
            return param1 - param2;
        }
    }
}

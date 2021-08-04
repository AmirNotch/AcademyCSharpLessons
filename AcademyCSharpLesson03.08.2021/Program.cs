using System;

namespace AcademyCSharpLesson03._08._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            // Прошу прощения что использую везде var но сейчас мы пользуемся только типом int и double
            // так что не тяжело понять что это за тип.

            //Problem 1
            var a = 16.80;
            var b = 12.40;

            var result = Math.Sqrt(a * b);
            Console.WriteLine($"Problem #1 {Math.Round(result, 2)}");
            Console.WriteLine();


            //Problem 2
            var A = 1.40;
            var B = -5.50;
            var C = 0.60;

            var AC = Math.Round(Math.Abs(A - C), 2);
            var BC = Math.Round(Math.Abs(B - C), 2);
            var result2 = Math.Round(AC + BC, 3);

            Console.WriteLine($"Problem #2 {String.Format("{0:F2}", result2)}");
            Console.WriteLine();


            //Problem 3
            var x1 = -6.20;
            var x2 = 2.10;
            var y1 = 5.20;
            var y2 = 9.80;

            var result3 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine($"Problem #3 {Math.Round(result3, 2)}");
            Console.WriteLine();


            //Problem 4
            var number1 = 41;
            if (number1 < 100)
            {
                Console.WriteLine($"Problem #4 {number1 % 10}{number1 / 10}");
            }
            else if (number1 > 100)

            {
                Console.WriteLine($"Problem #4 {number1 % 10}{(number1 / 10) % 10}{number1 / 100}");
            }
            Console.WriteLine();


            //Problem 5
            var n = 10985;
            var result5 = n / 60;
            Console.WriteLine($"Problem #5 {result5}");
            Console.WriteLine();


            //Problem 6
            var K = 202;
            var result6 = ((K % 7) + 0);
            Console.WriteLine($"Problem #6 {result6}");
        }
    }
}

using System;

namespace AcademyCSharpLesson19._08._2021_1_problem_with_Rectangle_
{
    class ClassRectangle
    {
        static void Main()
        {
            Console.Write("Введите число длины прямоугольника: ");
            var side1 = Convert.ToInt32(Console.ReadLine());
            Console.Write('\n');

            Console.Write("Введите число ширины прямоугольника: ");
            var side2 = Convert.ToInt32(Console.ReadLine());
            Console.Write('\n');

            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine($"Вычисления площади прямоугольника: { rectangle.AreaCalculator()}");
            Console.Write('\n');
            Console.WriteLine($"Периметр прямоугольника: {rectangle.PerimeterCalculator()}");

        }
    }
    class Rectangle
    {
        public double side1;
        public double side2;

        public double Area
        {
            get
            {
                return side1 * side2;
            }
        }
        public double Perimeter
        {
            get
            {
                return 2 * (side1 + side2);
            }
        }

        public double AreaCalculator()
        {
            return Area;
        }

        public double PerimeterCalculator()
        {
            return Perimeter;
        }

        public Rectangle()
        {

        }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
    }
}

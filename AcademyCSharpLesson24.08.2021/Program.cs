using System;

namespace AcademyCSharpLesson24._08._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какую валюты вы хотите конвертировать");
            Console.WriteLine("TJS, USD, EUR, RUB - Для конвертации USD, напишите заглавными буквами, Пример: USD");

            var money = Console.ReadLine();
            var usd = 0.0;
            var som = 0.0;
            var eur = 0.0;
            var rub = 0.0;

            if (money == "USD")
            {
                Console.WriteLine("Какую сумму вы хотите конвертировать");
                usd = Convert.ToDouble(Console.ReadLine());
                var converter = new Converter(som: som, usd: usd, eur: eur, rub: rub);
                converter.ConverterFromUSDToOther();
            }
            else if (money == "TJS")
            {
                Console.WriteLine("Какую сумму вы хотите конвертировать");
                som = Convert.ToDouble(Console.ReadLine());
                var converter = new Converter(som: som, usd: usd, eur: eur, rub: rub);
                converter.ConverterFromTJSToOther();
            }
            else if (money == "EUR")
            {
                Console.WriteLine("Какую сумму вы хотите конвертировать");
                eur = Convert.ToDouble(Console.ReadLine());
                var converter = new Converter(som: som, usd: usd, eur: eur, rub: rub);
                converter.ConverterFromEURToOther();
            }
            else if (money == "RUB")
            {
                Console.WriteLine("Какую сумму вы хотите конвертировать");
                rub = Convert.ToDouble(Console.ReadLine());
                var converter = new Converter(som: som, usd: usd, eur: eur, rub: rub);
                converter.ConverterFromRUBToOther();
            }
            else
            {
                Console.WriteLine("Такой Валюты не существует попробуйте ещё раз.");
            }


            Employee one = new Employee("Aziz", "Muminov", DateTime.Parse("24.04.2021"));
            Console.WriteLine("Name is {0}, surname is {1}. Date of hire: {2}", one.name, one.surname, one.DateOfHire);
            double salary = one.Calculation(Employee.Position.Middle);
            Console.WriteLine("Salary is {0}, tax is {1}, pension fund is {2}, position is {3}.", salary, salary * 0.13, salary * 0.01, Employee.Position.Middle);
        }
    }
    class Converter
    {
        public double som;
        public double usd;
        public double eur;
        public double rub;

        public Converter(double som, double usd, double eur, double rub)
        {
            this.som = som;
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public void ConverterFromTJSToOther()
        {
            if (som > 0)
            {
                Console.WriteLine($"{som} сомони ТАДЖИКИСТАН (TJS) в {Math.Round((som * 0.09), 2, MidpointRounding.ToEven)} доллар (USD)");
                Console.WriteLine($"{som} сомони ТАДЖИКИСТАН (TJS) в {Math.Round((som * 6.41), 2, MidpointRounding.ToZero)} рублях (RUB) ");
                Console.WriteLine($"{som} сомони ТАДЖИКИСТАН (TJS) в {Math.Round((som * 0.07), 2, MidpointRounding.ToZero)} евро (EUR) ");
            }
            else
            {
                Console.WriteLine("Вы ввели маленькую сумму либо ничего не ввели попробуйте ещё раз");
            }
        }
        public void ConverterFromUSDToOther()
        {
            if (usd > 0)
            {
                Console.WriteLine($"{usd} доллар США (USD) в {Math.Round((usd * 11.32), 2, MidpointRounding.ToZero)} сомони (TJS)");
                Console.WriteLine($"{usd} доллар США (USD) в {Math.Round((usd * 72.69), 2, MidpointRounding.ToZero)} рублях (RUB) ");
                Console.WriteLine($"{usd} доллар США (USD) в {Math.Round((usd * 0.83), 2, MidpointRounding.ToZero)} евро (EUR) ");
            }
            else
            {
                Console.WriteLine("Вы ввели маленькую сумму либо ничего не ввели попробуйте ещё раз");
            }
        }
        public void ConverterFromEURToOther()
        {
            if (eur > 0)
            {
                Console.WriteLine($"{eur} евро ЕВРОПА (EUR) в {Math.Round((eur * 1.17), 2, MidpointRounding.ToZero)} доллар (USD)");
                Console.WriteLine($"{eur} евро ЕВРОПА (EUR) в {Math.Round((eur * 85.26), 2, MidpointRounding.ToZero)} рублях (RUB) ");
                Console.WriteLine($"{eur} евро ЕВРОПА (EUR) в {Math.Round((eur * 13.30), 2, MidpointRounding.ToZero)} сомони (TJS) ");
            }
            else
            {
                Console.WriteLine("Вы ввели маленькую сумму либо ничего не ввели попробуйте ещё раз");
            }
        }
        public void ConverterFromRUBToOther()
        {
            if (rub > 0)
            {
                Console.WriteLine($"{rub} рублей РОССИЯ (RUB) в {Math.Round((rub * 0.014), 2, MidpointRounding.ToZero)} доллар (USD)");
                Console.WriteLine($"{rub} рублей РОССИЯ (RUB) в {Math.Round((rub * 0.011), 2, MidpointRounding.ToZero)} евро (EUR) ");
                Console.WriteLine($"{rub} рублей РОССИЯ (RUB) в {Math.Round((rub * 0.15), 2, MidpointRounding.ToZero)} сомони (TJS) ");
            }
            else
            {
                Console.WriteLine("Вы ввели маленькую сумму либо ничего не ввели попробуйте ещё раз");
            }
        }
    }

    public class Employee
    {
        DateTime dateOfHire;
        double salary;

        public enum Position
        {
            Junior = 1000,
            Middle = 10000,
            Senior = 100000
        }

        public string name;
        public string surname;
        public DateTime DateOfHire
        {
            get
            {
                return dateOfHire;
            }
            set
            {
                if (dateOfHire.Date < DateTime.Parse("01.01.2000"))
                {
                    dateOfHire = value;
                }
                else
                {
                    Console.WriteLine("Date before times!");
                }

            }
        }

        public Employee(string name, string surname, DateTime dateOfHire)
        {
            this.name = name;
            this.surname = surname;
            DateOfHire = dateOfHire;
        }
        
        // метод, который определяет повышающий коэффициент в зависимости от стажа в днях
        // метод можно использовать а можно и нет.
        public double DiscoverGrade(DateTime dateOfHire)
        {
            double dateValueForGrade = (DateTime.Now - dateOfHire).TotalDays;

            if (dateValueForGrade >= 182 && dateValueForGrade < 365)
                return 1.5;
            else if (dateValueForGrade >= 365)
                return 1.25;
            else
                return 1.0;
        }

        // метод, где через Enum и Switch рассчитывается заработная плата
        public double Calculation(Position position)
        {
            double grade = DiscoverGrade(dateOfHire);
            switch (position)
            {
                case Position.Junior:
                    salary = 1000 * grade;
                    return salary;
                case Position.Middle:
                    salary = 10000 * grade;
                    return salary;
                case Position.Senior:
                    salary = 100000 * grade;
                    return salary;
                default:
                    Console.WriteLine("No such position!");
                    break;

            }
            return 0.0;
        }
    }
}
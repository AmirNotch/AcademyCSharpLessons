using System;
using System.Collections.Generic;

namespace AcademyCSharpLesson21._09._2021
{

    class HomeLesson
    {
        static void Main()
        {
            Console.WriteLine("Первая программа LIST");
            // 1 Задача
            List<SmartPhones<string, decimal>> smartPhones = new List<SmartPhones<string, decimal>>();

            smartPhones.Add(new SmartPhones<string, decimal> { Kachestvo = "Nice", Model = "Samsung", Price = 1000m });
            smartPhones.Add(new SmartPhones<string, decimal> { Kachestvo = "Nice", Model = "Iphone", Price = 1000m });
            smartPhones.Add(new SmartPhones<string, decimal> { Kachestvo = "Normal", Model = "Xiaomi", Price = 950m });
            smartPhones.Add(new SmartPhones<string, decimal> { Kachestvo = "Normal", Model = "Huawei", Price = 700m });

            bool working = true;
            while (working)
            {
                Console.WriteLine("1.Выйти\n2.Добавить Телефон\n3.Выберать Телефон по Ключу(Телефону)\n4.Посчитать общее количество Телефонов\nВыбор:");
                int.TryParse(Console.ReadLine(), out var choice);
                switch (choice)
                {
                    case 1:
                        working = false;
                        break;
                    case 2:
                        {
                            Console.Write("Качество: ");
                            var kachestvo = Console.ReadLine();
                            Console.Write("Модель телефона: ");
                            var model = Console.ReadLine();
                            Console.Write("Цена: ");
                            Decimal.TryParse(Console.ReadLine(), out var price);
                            smartPhones.Add(new SmartPhones<string, decimal> { Kachestvo = kachestvo, Model = model, Price = price });
                        }
                        break;
                    case 3:
                        {
                            foreach (SmartPhones<string, decimal> items in smartPhones)
                            {
                                Console.WriteLine($"Модель: {items.Model} - Качество: {items.Kachestvo} - Цена: {items.Price}");
                            }
                            Console.Write("Выберите Модель Телефона :");

                            var model = Console.ReadLine();
                            /*Console.WriteLine(laptops[model].Price);*/
                            Console.WriteLine();

                            var number = 0;
                            foreach (SmartPhones<string, decimal> items in smartPhones)
                            {
                                if (items.Model == model)
                                {
                                    Console.WriteLine($"Модель: {items.Model} - Качество: {items.Kachestvo} - Цена: {items.Price}");
                                    Console.WriteLine($"Индекс: Элемента {++number}");
                                }
                                number++;
                            }
                        }
                        break;
                    case 4:
                        {
                            var number = 0;
                            for (int i = 0; i < smartPhones.Count; i++)
                            {
                                if (i == smartPhones.Count - 1)
                                {
                                    Console.WriteLine($"Всего {++number} Телефонов");
                                }
                                number++;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Something went wrong!!!");
                        break;
                }
            }

            Console.Clear();
            Console.WriteLine("Вторая программа Dictionary");
            // 2 Задача
            Dictionary<string, ModelsLaptop<String, decimal>> laptops = new Dictionary<string, ModelsLaptop<string, decimal>>();

            laptops.Add("Lenovo", new ModelsLaptop<string, decimal> { Kachestvo = "Bad", Price = 500.00m });
            laptops.Add("MacBook", new ModelsLaptop<string, decimal> { Kachestvo = "Nice", Price = 1000.00m });
            laptops.Add("Dell", new ModelsLaptop<string, decimal> { Kachestvo = "Normal", Price = 800.00m });
            laptops.Add("HP-Omen", new ModelsLaptop<string, decimal> { Kachestvo = "Normal", Price = 700.00m });

            working = true;
            while (working)
            {
                Console.WriteLine("1.Выйти\n2.Добавить Ноутбук\n3.Выберать Ноутбук по Ключу(Ноутбуку)\n4.Посчитать общее количество Ноутбук\nВыбор:");
                int.TryParse(Console.ReadLine(), out var choice);
                switch (choice)
                {
                    case 1:
                        working = false;
                        break;
                    case 2:
                        {
                            Console.Write("Качество: ");
                            var kachestvo = Console.ReadLine();
                            Console.Write("Модель ноута: ");
                            var model = Console.ReadLine();
                            Console.Write("Цена: ");
                            Decimal.TryParse(Console.ReadLine(), out var price);
                            laptops.Add(model, new ModelsLaptop<string, decimal> { Kachestvo = kachestvo, Price = price });
                        }
                        break;
                    case 3:
                        {
                            foreach (KeyValuePair<string, ModelsLaptop<string, decimal>> item in laptops)
                            {
                                Console.WriteLine($"Модель: {item.Key} - Качество: {item.Value.Kachestvo} - Цена: {item.Value.Price}");
                            }
                            Console.Write("Выберите Модель Ноутбука :");
                            var model = Console.ReadLine();
                            /*Console.WriteLine(laptops[model].Price);*/
                            Console.WriteLine();

                            var numbers = 0;
                            foreach (KeyValuePair<string, ModelsLaptop<string, decimal>> items in laptops)
                            {
                                if (items.Key == model)
                                {
                                    Console.WriteLine($"Модель: {items.Key} - Качество: {items.Value.Kachestvo} - Цена: {items.Value.Price}");
                                    Console.WriteLine($"Индекс: Элемента {++numbers}");
                                }
                                numbers++;
                            }
                        }
                        break;
                    case 4:
                        var number = 0;
                        for (int i = 0; i < laptops.Count; i++)
                        {
                            if (i == laptops.Count - 1)
                            {
                                Console.WriteLine($"Всего {++number} Ноутбук");
                            }
                            number++;
                        }
                        break;
                    default:
                        Console.WriteLine("Something went wrong!!!");
                        break;
                }
            }
        }
    }

    public class ModelsLaptop<T, U>
    {
        public T Kachestvo { get; set; }
        public U Price { get; set; }
    }

    public class SmartPhones<T, Z>
    {
        public T Kachestvo { get; set; }
        public T Model { get; set; }
        public Z Price { get; set; }
    }
}

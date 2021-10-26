using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace AcademyCSharpLesson16._10._2021
{
    class Program
    {
        static async Task Main(string[] args)
        {
            bool working = true;
            while (working)
            {
                Console.Write("Выберите действие\n");
                Console.Write("1.Добавить\n2.Вывести на консоль весь список\n3.Редактировать по Id\n4.Удачить по Id\n5.Завершить программу\n");
                int.TryParse(Console.ReadLine(), out var choice);
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Выберите имя");
                        var name = Console.ReadLine();
                        Console.WriteLine("Выберите Фамилию");
                        var lastName = Console.ReadLine();
                        Console.WriteLine("Выберите Отчество");
                        var middleName = Console.ReadLine();
                        // Добавление
                        using (var applicationContext = new ApplicationContext())
                        {
                            var clients = await applicationContext.Clients.ToListAsync();

                            Client user1 = new Client() { LastName = lastName, FirstName = name, MiddleName = middleName, Created_At = DateTime.Now };

                            applicationContext.Add(user1);
                            await applicationContext.SaveChangesAsync();
                        }

                        break;
                    case 2:
                        // получение
                        using (var applicationContext = new ApplicationContext())
                        {
                            var clients = await applicationContext.Clients.ToListAsync();
                            Console.WriteLine("Данные получены");

                            foreach (Client item in clients)
                            {
                                Console.WriteLine($"{item.Id}, {item.LastName}, {item.FirstName}, {item.MiddleName}, {item.Created_At}, {item.Updated_At}");
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Выберите Id");
                        int.TryParse(Console.ReadLine(), out var id);
                        Console.WriteLine("Выберите имя");
                        var nameUpdate = Console.ReadLine();
                        Console.WriteLine("Выберите Фамилию");
                        var lastNameUpdate = Console.ReadLine();
                        Console.WriteLine("Выберите Отчество");
                        var middleNameUpdate = Console.ReadLine();

                        // Редактирование
                        using (var applicationContext = new ApplicationContext())
                        {

                            Client client = await applicationContext.Clients.FindAsync(id);
                            if (client != null)
                            {
                                client.FirstName = nameUpdate;
                                client.LastName = lastNameUpdate;
                                client.MiddleName = middleNameUpdate;
                                client.Updated_At = DateTime.Now;

                                applicationContext.Update(client);
                                await applicationContext.SaveChangesAsync();
                            }

                            var clients = await applicationContext.Clients.ToListAsync();
                            foreach (Client item in clients)
                            {
                                Console.WriteLine($"{item.Id}, {item.LastName}, {item.FirstName}, {item.MiddleName}, {item.Created_At}, {item.Updated_At}");
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Выберите Id");
                        int.TryParse(Console.ReadLine(), out var idDelete);

                        // Удаление
                        using (var applicationContext = new ApplicationContext())
                        {

                            Client client = await applicationContext.Clients.FindAsync(idDelete);
                            if (client != null)
                            {
                                applicationContext.Remove(client);
                                await applicationContext.SaveChangesAsync();
                            }

                            var clients = await applicationContext.Clients.ToListAsync();
                            foreach (Client item in clients)
                            {
                                Console.WriteLine($"{item.Id}, {item.LastName}, {item.FirstName}, {item.MiddleName}, {item.Created_At}, {item.Updated_At}");
                            }
                        }
                        break;
                    case 5:
                        working = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

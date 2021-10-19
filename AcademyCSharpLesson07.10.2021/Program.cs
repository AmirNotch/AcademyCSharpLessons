using System;
using System.Collections.Generic;
using System.Threading;

namespace AcademyCSharpLesson07._10._2021
{
    public class MainThread
    {
        static List<Client> client = new List<Client>();

        static object locker = new object();
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2");

            Client clientsInsert;

            clientsInsert = new Client
            {
                Id = 1,
                Balance = 100,
                Year = DateTime.Now
            };

            Thread myThreadInsert = new Thread(new ParameterizedThreadStart(Insert));
            myThreadInsert.Start(clientsInsert);

            Thread.Sleep(2000);
            Client clientsUpdate;
            clientsUpdate = new Client
            {
                Id = 1,
                Balance = 800,
                Year = DateTime.Now
            };

            Thread myThreadUpdate = new Thread(new ParameterizedThreadStart(Update));
            myThreadUpdate.Start(clientsUpdate);

            Thread.Sleep(3000);
            Thread myThreadDelete = new Thread(Delete);
            myThreadDelete.Start();

            Thread.Sleep(4000);
            Thread myThreadSelect = new Thread(Select);
            myThreadSelect.Start();

            /*Thread.Sleep(4000);
            int num = 0;
            TimerCallback tm = new TimerCallback(Select);
            Timer timer = new Timer(tm, num, 10000, 0);*/
            Console.ReadLine();
        }

        public static void Insert(object obj)
        {
            lock (locker)
            {
                try
                {
                    for (int i = 1, y = 2; i < 15; i++)
                    {
                        var random = new Random().Next(-1000, 5000);
                        Client clientInsert = (Client)obj;
                        if (i >= 8)
                        {
                            client.Add(new Client { Id = y, Balance = clientInsert.Balance + random });
                            Thread.Sleep(300);
                        }
                        //Client clientInsert = (Client)obj;
                        client.Add(new Client { Id = clientInsert.Id, Balance = clientInsert.Balance + random });
                        Thread.Sleep(300);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static void Update(object obj)
        {
            lock (locker)
            {
                for (int i = 1, y = 2; i < 15; i++)
                {
                    var random = new Random().Next(-1000, 5000);
                    Client clientUpdate = (Client)obj;
                    if (i >= 8)
                    {
                        client.Add(new Client { Id = y, Balance = clientUpdate.Balance + random });
                        Thread.Sleep(300);
                    }
                    //Client clientInsert = (Client)obj;
                    client.Insert(1 * i, new Client { Id = clientUpdate.Id, Balance = clientUpdate.Balance + random, Year = clientUpdate.Year });
                    Thread.Sleep(200);
                }
            }
        }

        public static void Delete()
        {
            lock (locker)
            {
                for (int i = 0; i < 9; i++)
                {
                    var random = new Random().Next(1, 15);
                    client.RemoveAt(random);
                    Thread.Sleep(200);
                }
            }
        }

        public static void Select(object obj)
        {
            lock (locker)
            {
                foreach (Client clientSelect in client)
                {
                    Console.Write("Id: " + clientSelect.Id + ", Balance: " + clientSelect.Balance + ", Year: " + clientSelect.Year + "\n");
                    Thread.Sleep(100);
                }

                Console.WriteLine();


                int num = 0;
                TimerCallback tm = new TimerCallback(TimerSelect);
                Timer timer = new Timer(tm, num, 300, 0);

                static void TimerSelect(object obj)
                {
                    Console.WriteLine("Задание 3");
                    var amount = (int)obj;
                    for (int i = 0; i < client.Count; i++)
                    {
                        Thread.Sleep(200);
                        if (amount == 0)
                        {
                            amount++;
                            continue;
                        }

                        else if (client[i - 1].Balance > client[i].Balance)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Id: " + client[i].Id + ", Balance before: " + client[i - 1].Balance + ", Balance after: " + client[i].Balance + " difference: \"-\"" + (client[i - 1].Balance - client[i].Balance));
                            Console.ResetColor();
                            Console.WriteLine();

                        }
                        else if (client[i - 1].Balance < client[i].Balance)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Id: " + client[i].Id + ", Balance before: " + client[i - 1].Balance + ", Balance after: " + client[i].Balance + " difference: \"+\"" + (client[i].Balance - client[i - 1].Balance));
                            Console.ResetColor();
                            Console.WriteLine();
                        }
                        else if (client[i - 1].Balance == client[i].Balance)
                        {
                            continue;
                        }

                    }
                }
            }
        }

        /*public static void TimerSelect(object obj)
        {
            Console.WriteLine("Задание 3");
            var amount = (int)obj;
            for (int i = 0; i < client.Count; i++)
            {
                Thread.Sleep(200);
                if (amount == 0)
                {
                    amount++;
                    continue;
                }

                else if (client[i - 1].Balance > client[i].Balance)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Id: " + client[i].Id + ", Balance before: " + client[i - 1].Balance + ", Balance after: " + client[i].Balance + " difference: \"-\"" + (client[i - 1].Balance - client[i].Balance));
                    Console.ResetColor();
                    Console.WriteLine();

                }
                else if (client[i - 1].Balance < client[i].Balance)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Id: " + client[i].Id + ", Balance before: " + client[i - 1].Balance + ", Balance after: " + client[i].Balance + " difference: \"+\"" + (client[i].Balance - client[i - 1].Balance));
                    Console.ResetColor();
                    Console.WriteLine();
                }
                else if (client[i - 1].Balance == client[i].Balance)
                {
                    continue;
                }

            }
            return;

        }*/
    }

    public class Client
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public DateTime Year { get; set; }
    }
}

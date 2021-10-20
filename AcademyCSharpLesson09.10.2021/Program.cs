using System;
using System.Threading;

namespace AcademyCSharpLesson09._10._2021
{
    class Program
    {
        static void Main()
        {
            MatrixSymbols instance;

            for (int i = 0; i < 26; i++)
            {
                instance = new MatrixSymbols(i * 3, true);
                new Thread(instance.Move).Start();
            }
        }
    }

    class MatrixSymbols
    {
        static object locker = new object();

        Random random;

        const string litters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public int Colunm { get; set; }

        public bool NeedSecond { get; set; }

        public MatrixSymbols(int col, bool needSecond)
        {
            Colunm = col;
            random = new Random((int)DateTime.Now.Ticks);
            NeedSecond = needSecond;
        }

        private char GetChar()
        {
            return litters.ToCharArray()[random.Next(0, 35)];
        }

        public void Move()
        {
            int lenght;
            int count;

            while (true)
            {
                count = random.Next(5, 10);
                lenght = 0;
                Thread.Sleep(random.Next(0, 5000));
                for (int i = 0; i < 38; i++)
                {
                    lock (locker)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.CursorTop = i - lenght;
                        for (int j = i - lenght - 1; j < i; j++)
                        {
                            Console.CursorLeft = Colunm;
                            Console.WriteLine("в–€");
                        }

                        if (lenght < count)
                            lenght++;
                        else
                            if (lenght == count)
                            count = 0;
                        if (NeedSecond && i < 20 && i > lenght + 2 && (random.Next(1, 5) == 3))
                        {
                            new Thread((new MatrixSymbols(Colunm, false)).Move).Start();
                            NeedSecond = false;
                        }

                        if (39 - i < lenght)
                            lenght--;
                        Console.CursorTop = i - lenght + 1;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        for (int j = 0; j < lenght - 2; j++)
                        {
                            Console.CursorLeft = Colunm;
                            Console.WriteLine(GetChar());
                        }
                        if (lenght >= 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.CursorLeft = Colunm;
                            Console.WriteLine(GetChar());
                        }
                        if (lenght >= 1)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.CursorLeft = Colunm;
                            Console.WriteLine(GetChar());
                        }

                        Thread.Sleep(50);
                    }
                }
            }
        }
    }
}

using System;
using System.Threading;
using System.Threading.Tasks;

namespace AcademyCSharpLesson09._10._2021
{
    class Program
    {
        static void Main()
        {
            MatrixSymbols appearence;

            for (int i = 0; i < 40; i++)
            {
                appearence = new MatrixSymbols(i * 3, true);
                new Thread(appearence.Move).Start();
            }
        }
    }

    class MatrixSymbols
    {
        static object locker = new object();

        Random random;

        const string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789@#$%&";

        public int Colunm { get; set; }

        public bool NeedSecond { get; set; }

        // Конструктор где прописывем колонку и ожиданиеВремени = true 
        public MatrixSymbols(int column, bool needSecond)
        {
            Colunm = column;
            random = new Random((int)DateTime.Now.Ticks);
            NeedSecond = needSecond;
        }
        // Получаем рандомный символ 
        private char GetChar()
        {
            return symbols.ToCharArray()[random.Next(0, symbols.Length)];
        }
        // Метод который запускает потоки
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
                            /*//Thread.Sleep(2000);
                            Console.CursorLeft = Colunm;
                            Console.WriteLine(GetChar());*/
                        }
                        if (lenght >= 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.CursorLeft = Colunm;
                            Console.WriteLine(GetChar());
                            /*//Thread.Sleep(2000);
                            Console.CursorLeft = Colunm;
                            Console.WriteLine(GetChar());*/
                        }
                        if (lenght >= 1)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.CursorLeft = Colunm;
                            Console.WriteLine(GetChar());
                            /*//Thread.Sleep(2000);
                            Console.CursorLeft = Colunm;
                            Console.WriteLine(GetChar());*/
                        }

                        Thread.Sleep(50);
                    }
                }
            }
        }
    }
}

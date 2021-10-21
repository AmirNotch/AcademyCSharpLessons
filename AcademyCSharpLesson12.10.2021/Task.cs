/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AcademyCSharpLesson12._10._2021
{
    class Task
    {
        // Метод выполняемый в качестве задачи
        static void MyTask()
        {
            Console.WriteLine("MyTask() запущен");

            for (int count = 0; count < 10; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("В методе MyTask подсчет равен "+count);
            }
        }

        static void Main()
        {
            Console.WriteLine("Основной поток запущен");

            *//*Task task = new Task(MyTask);*//*

            Task task = new Task(MyTask);

            // Запустить задачу
            task.Start();

            for (int i = 0; i < 60; i++)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }

            Console.WriteLine("Основной поток завершен");
            Console.ReadLine();
        }
    }
}
*/
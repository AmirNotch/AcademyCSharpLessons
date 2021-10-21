using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyCSharpLesson12._10._2021
{
    class Async
    {
        // Операторы async и await используются вместе для создания асинхронного метода
        // Такой метод, определенный с помощью модификатора async и содержащий одно или несколько выражений await, называется асинхронным методом
        static void Main(string[] args)
        {
            // Отработает асинхронно
            DisplayResultAsync();
            // Отработает первым т.к. на асинхронный метод повлияет некоторая задержка при выполнении операций
            Console.WriteLine("Non Async");
            Console.ReadLine();
        }

        //async - указывает, что метод является асинхронными
        static async void DisplayResultAsync()
        {
            int num = 5;
            //await применяется к задаче в асинхронных методах, приостанавливает выполнение метода, пока задача не завершится
            //Выполнение потока, в котором был вызван асинхронный метод не прервется
            //Метод AsyncMethod возвращает объект асинхронной задачи Task<int>, возможно вызвать с await
            //await-метод возвращает результат
            int result = await AsyncMethod(num);
            Console.WriteLine("Async result {0}", result);
        }

        static Task<int> AsyncMethod(int x)
        {
            int result = 1;
            return Task.Run(() => { result *= x; return result; });
        }
    }
}

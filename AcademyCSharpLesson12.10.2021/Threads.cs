/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AcademyCSharpLesson12._10._2021
{
    class Threads
    {
        static void mythread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Поток 1 выводит " + i);
            }
        }

        static void mythread2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Поток 2 выводит " + i);
            }
        }

        static void Main(string[] args)
        {
            Thread thread1 = new Thread(mythread1);
            Thread thread2 = new Thread(mythread2);

            thread1.Start();
            thread2.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Поток 3 выводит " + i);
            }
            Console.ReadLine();
        }
    }
}
*/
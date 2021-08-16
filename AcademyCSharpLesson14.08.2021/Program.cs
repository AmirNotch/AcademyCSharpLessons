using System;

namespace AcademyCSharpLesson14._08._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Программа #1 \n");
            Console.WriteLine("Введите размер массива :");
            var arrayNumber = Convert.ToInt32(Console.ReadLine());
            var array = new int[arrayNumber];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
            }
            var maximumIndex = 0;
            var minimumIndex = 100;
            var sumAllIndex = 0;
            Console.WriteLine(); 
            foreach (var item in array)
            {
                
                if (item > maximumIndex)
                {
                    maximumIndex = item;
                }
                if (item < minimumIndex)
                {
                    minimumIndex = item;
                }
                sumAllIndex += item;
                if (item % 2 != 0)
                {
                    Console.WriteLine("Нечётное число {0}",item);
                }

            }
            Console.WriteLine();
            Console.WriteLine("Максимальное число массива {0}\n",maximumIndex);
            Console.WriteLine("Минимальное число массива {0}\n", minimumIndex);
            Console.WriteLine("Сумма всех элементов массива {0}\n",sumAllIndex);
            Console.WriteLine("Среднее арифметическое всех элементов массива {0}", (double)sumAllIndex / array.Length);
            Console.WriteLine();



            // Problem 2
            Console.Write("Программа #2 \n");
            Console.WriteLine("Введите размер массива :");
            var arrayNumber2 = Convert.ToInt32(Console.ReadLine());
            var array2 = new int[arrayNumber2];
            var arrayInverse = new int[arrayNumber2];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = random.Next(0, 100);
            }
            for (int i = 0, j = array2.Length-1; i < array2.Length; i++, j--)
            {
                arrayInverse[j] = array2[i];
            }
            Console.Write("Array : ");
            foreach (var item in array2)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n");
            Console.Write("Inverse Array : ");
            foreach (var item in arrayInverse)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine('\n');


            // Problem 3
            Console.WriteLine("Программа #3 \n");
            Console.WriteLine("Введите размер массива :");
            var arrayNumber3 = Convert.ToInt32(Console.ReadLine());
            var array3 = new int[arrayNumber3];
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = random.Next(0, 100);
            }
            Console.Write("Array : ");
            foreach (var item in array3)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Введите размер нового массива :");
            var count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите Индекс предыдущего массива :");
            var index = Convert.ToInt32(Console.ReadLine());
            var array4 = new int[count];
            for (int i = 0; i < array4.Length; i++, index++)
            {
                if (index >= array3.Length)
                {
                    array4[i] = 1;
                }
                else
                {
                    array4[i] = array3[index];
                }
            }

            Console.Write("New Array : ");
            foreach (var item in array4)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}

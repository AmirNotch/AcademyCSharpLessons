using System;

namespace AcademyCSharpLesson18._09._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayInt = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            var arrayString = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            var arrayDouble = new double[] { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0 };
            var arrayFloat = new float[] { 1.0f, 2.0f, 3.0f, 4.0f, 5.0f, 6.0f, 7.0f, 8.0f, 9.0f };
            var arrayDecimal = new decimal[] { 1.0m, 2.0m, 3.0m, 4.0m, 5.0m, 6.0m, 7.0m, 8.0m, 9.0m };

            Console.WriteLine("Pop overload methods.");
            ArrayHelper<Int32>.Pop<Int32>(ref arrayInt, 0);
            Console.WriteLine();
            ArrayHelper<string>.Pop<string>(ref arrayString, "");
            Console.WriteLine();
            ArrayHelper<double>.Pop<double>(ref arrayDouble, 0.0);
            Console.WriteLine();
            ArrayHelper<float>.Pop<float>(ref arrayFloat, 0f);
            Console.WriteLine();
            ArrayHelper<decimal>.Pop<decimal>(ref arrayDecimal, 0m);
            Console.WriteLine();

            Console.WriteLine("Push overload methods.");
            ArrayHelper<Int32>.Push<Int32>(ref arrayInt, 10);
            ArrayHelper<string>.Push<string>(ref arrayString, "10");
            ArrayHelper<double>.Push<double>(ref arrayDouble, 10.0);
            ArrayHelper<float>.Push<float>(ref arrayFloat, 10.0f);
            ArrayHelper<decimal>.Push<decimal>(ref arrayDecimal, 10.0m);
            Console.WriteLine();

            Console.WriteLine("Shift overload methods.");
            ArrayHelper<Int32>.Shift<Int32>(ref arrayInt);
            ArrayHelper<String>.Shift<String>(ref arrayString);
            ArrayHelper<double>.Shift<Double>(ref arrayDouble);
            ArrayHelper<decimal>.Shift<decimal>(ref arrayDecimal);
            ArrayHelper<float>.Shift<float>(ref arrayFloat);
            Console.WriteLine();

            Console.WriteLine("UnShift overload methods.");
            ArrayHelper<Int32>.UnShift<Int32>(ref arrayInt, 8);
            ArrayHelper<decimal>.UnShift<decimal>(ref arrayDecimal, 8m);
            ArrayHelper<double>.UnShift<Double>(ref arrayDouble, 8);
            ArrayHelper<float>.UnShift<float>(ref arrayFloat, 8f);
            ArrayHelper<string>.UnShift<String>(ref arrayString, "8");
            Console.WriteLine();


            var arrayInt2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var arrayString2 = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            var arrayDouble2 = new double[] { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0 };
            var arrayFloat2 = new float[] { 1.0f, 2.0f, 3.0f, 4.0f, 5.0f, 6.0f, 7.0f, 8.0f, 9.0f };
            var arrayDecimal2 = new decimal[] { 1.0m, 2.0m, 3.0m, 4.0m, 5.0m, 6.0m, 7.0m, 8.0m, 9.0m };

            Console.WriteLine("Slice overload methods.");
            ArrayHelper<Int32>.Slice<Int32>(arrayInt2, 1, 9);
            Console.WriteLine();
            ArrayHelper<string>.Slice<string>(arrayString2, 1, 9);
            Console.WriteLine();
            ArrayHelper<double>.Slice<double>(arrayDouble2, 1, 9);
            Console.WriteLine();
            ArrayHelper<float>.Slice<float>(arrayFloat2, 1, 9);
            Console.WriteLine();
            ArrayHelper<decimal>.Slice<decimal>(arrayDecimal2, 1, 9);
        }
    }

    static class ArrayHelper<T>
    {
        // Pop overload methods.
        public static void Pop<T>(ref T[] array, T zero)
        {
            var arrayReturn = zero;
            if (array.Length > 0)
            {
                var arrayCollect = new T[array.Length - 1];
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[array.Length - 1].Equals(array[i]))
                    {
                        arrayReturn = array[i];
                        break;
                    }
                    arrayCollect[i] = array[i];
                    Console.Write(arrayCollect[i] + "\t");
                }
                Console.WriteLine();
                for (int i = 0; i < arrayCollect.Length; i++)
                {
                    array[i] = arrayCollect[i];
                }
            }
            else
            {
                Console.WriteLine("Пустой Массив");
                return;
            }
            Console.WriteLine();
            Console.WriteLine("Последний Элемент ");
            Console.WriteLine(arrayReturn);
            return;

        }

        // Push overload methods
        public static void Push<T>(ref T[] array, T element)
        {
            var arrayCollect = new T[array.Length];
            if (array.Length > 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    arrayCollect[i] = array[i];
                }
                Console.WriteLine();
                array = new T[arrayCollect.Length + 1];
                for (int i = 0; i < arrayCollect.Length + 1; i++)
                {
                    if (i == arrayCollect.Length)
                    {
                        array[i] = element;
                        if (true)
                        {
                            Console.Write(array[i] + "\t");
                        }
                        break;
                    }
                    else
                    {
                        array[i] = arrayCollect[i];
                    }
                    Console.Write(array[i] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine("Добавленный Элемент " + element);

            }
            else
            {
                Console.WriteLine("Пустой Массив");
                array = new T[1];
                array[0] = element;
                Console.WriteLine("Добавленный Элемент " + array[0]);
            }

        }

        // Shift overload methods.
        public static void Shift<T>(ref T[] array)
        {
            var a = array[0];
            var arrayCollect = new T[array.Length - 1];
            if (array.Length > 0)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    arrayCollect[i - 1] = array[i];
                }
                Console.WriteLine();
                array = new T[arrayCollect.Length];
                for (int i = 0; i < arrayCollect.Length; i++)
                {
                    array[i] = arrayCollect[i];

                    Console.Write(array[i] + "\t");
                }
                Console.WriteLine("Удалённый элемент " + a);

            }
            else
            {
                Console.WriteLine("Пустой Массив");
                array = new T[1];
                Console.WriteLine("Добавленный Элемент " + array[0]);
            }
        }

        // UnShift overload methods.
        public static void UnShift<T>(ref T[] array, T element)
        {
            var arrayCollect = new T[array.Length + 1];
            if (array.Length > 0)
            {
                for (int i = 0; i < array.Length + 1; i++)
                {
                    if (i == 0)
                    {
                        arrayCollect[i] = element;
                    }
                    else
                    {
                        arrayCollect[i] = array[i - 1];
                    }
                }
                Console.WriteLine();
                array = new T[arrayCollect.Length];
                for (int i = 0; i < arrayCollect.Length; i++)
                {
                    array[i] = arrayCollect[i];

                    Console.Write(array[i] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine("Добавленный Элемент " + element);
            }
            else
            {
                Console.WriteLine("Пустой Массив");
                for (int i = 0; i < array.Length + 1; i++)
                {
                    if (i == 0)
                    {
                        arrayCollect[i] = element;
                    }
                    else
                    {
                        arrayCollect[i] = array[i - 1];
                    }
                }
                array = new T[arrayCollect.Length];
                for (int i = 0; i < arrayCollect.Length; i++)
                {
                    array[i] = arrayCollect[i];

                    Console.Write(array[i] + "\t");
                }
                Console.WriteLine("Добавленный Элемент " + element);
            }
        }

        // Slice overload methods
        public static void Slice<T>(T[] array, int beginIndex, int endIndex = 0)
        {
            var number = 0;
            if (endIndex != 0)
            {
                var arrayCollect = new T[array.Length - (array.Length - endIndex)];
                for (int i = 0; i < array.Length; i++)
                {
                    if ((array.Length - (array.Length - endIndex)) == i)
                    {
                        break;
                    }
                    arrayCollect[i] = array[i];
                }
                var arrayCollect2 = new T[arrayCollect.Length - beginIndex - 1];
                for (int i = 0; i < arrayCollect.Length; i++)
                {
                    if (i < beginIndex)
                    {
                        continue;
                    }
                    else if (i == arrayCollect.Length - 1)
                    {
                        break;
                    }
                    arrayCollect2[number++] = arrayCollect[i];
                }

                foreach (var item in arrayCollect2)
                {
                    Console.Write($"{item} " + "\t");
                }
            }
            else
            {
                var arrayCollect = new T[array.Length - beginIndex];
                for (int i = 0; i < array.Length; i++)
                {
                    if (i < beginIndex)
                    {
                        continue;
                    }
                    arrayCollect[number++] = array[i];
                }
                foreach (var item in arrayCollect)
                {
                    Console.Write($"{item} " + "\t");
                }
            }
            Console.WriteLine();
        }
    }
}

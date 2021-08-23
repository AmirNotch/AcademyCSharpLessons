using System;

namespace AcademyCSharpLesson21._08._2021
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
            ArrayHelper.Pop(ref arrayInt);
            Console.WriteLine();
            ArrayHelper.Pop(ref arrayString);
            Console.WriteLine();
            ArrayHelper.Pop(ref arrayDouble);
            Console.WriteLine();
            ArrayHelper.Pop(ref arrayFloat);
            Console.WriteLine();
            ArrayHelper.Pop(ref arrayDecimal);
            Console.WriteLine();

            Console.WriteLine("Push overload methods.");
            ArrayHelper.Push(ref arrayInt, 10);
            ArrayHelper.Push(ref arrayString, "10");
            ArrayHelper.Push(ref arrayDouble, 10.0);
            ArrayHelper.Push(ref arrayFloat, 10.0f);
            ArrayHelper.Push(ref arrayDecimal, 10.0m);
            Console.WriteLine();

            Console.WriteLine("Shift overload methods.");
            ArrayHelper.Shift(ref arrayInt);
            ArrayHelper.Shift(ref arrayString);
            ArrayHelper.Shift(ref arrayDouble);
            ArrayHelper.Shift(ref arrayDecimal);
            ArrayHelper.Shift(ref arrayFloat);
            Console.WriteLine();
            
            Console.WriteLine("UnShift overload methods.");
            ArrayHelper.UnShift(ref arrayInt, 8);
            ArrayHelper.UnShift(ref arrayDecimal, 8m);
            ArrayHelper.UnShift(ref arrayDouble, 8);
            ArrayHelper.UnShift(ref arrayFloat, 8f);
            ArrayHelper.UnShift(ref arrayString, "8");
        }
    }
    static class ArrayHelper
    {
        // Pop overload methods.
        public static string Pop(ref string[] array)
        {
            var arrayReturn = "";
            if (array.Length > 0)
            {
                var arrayCollect = new string[array.Length - 1];
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[array.Length - 1] == array[i])
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
                return "";
            }
            Console.WriteLine();
            Console.WriteLine("Последний Элемент ");
            Console.WriteLine(arrayReturn);
            return arrayReturn;

        }
        public static int Pop(ref int[] array)
        {
            var arrayReturn = 0;
            if (array.Length > 0)
            {
                var arrayCollect = new int[array.Length - 1];
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[array.Length - 1] == array[i])
                    {
                        arrayReturn = array[i];
                        break;
                    }
                    arrayCollect[i] = array[i];
                }
                Console.WriteLine();
                for (int i = 0; i < arrayCollect.Length; i++)
                {
                    array[i] = arrayCollect[i];
                    Console.Write(array[i] + "\t");
                }
            }
            else
            {
                Console.WriteLine("Пустой Массив");
                return 0;
            }
            Console.WriteLine();
            Console.WriteLine("Последний Элемент ");
            Console.WriteLine(arrayReturn);
            return arrayReturn;
        }
        public static double Pop(ref double[] array)
        {
            var arrayReturn = 0.0;
            if (array.Length > 0)
            {
                var arrayCollect = new double[array.Length - 1];

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[array.Length - 1] == array[i])
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
                return 0.0;
            }
            Console.WriteLine();
            Console.WriteLine("Последний Элемент ");
            Console.WriteLine(arrayReturn);
            return arrayReturn;
        }
        public static decimal Pop(ref decimal[] array)
        {
            var arrayReturn = 0m;
            if (array.Length > 0)
            {
                var arrayCollect = new decimal[array.Length - 1];

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[array.Length - 1] == array[i])
                    {
                        arrayReturn = array[i];
                        break;
                    }
                    arrayCollect[i] = array[i];
                }
                Console.WriteLine();
                for (int i = 0; i < arrayCollect.Length; i++)
                {
                    array[i] = arrayCollect[i];
                    Console.Write(array[i] + "\t");
                }
            }
            else
            {
                Console.WriteLine("Пустой Массив");
                return 0m;
            }
            Console.WriteLine();
            Console.WriteLine("Последний Элемент ");
            Console.WriteLine(arrayReturn);
            return arrayReturn;
        }
        public static float Pop(ref float[] array)
        {
            var arrayReturn = 0f;
            if (array.Length > 0)
            {
                var arrayCollect = new float[array.Length - 1];

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[array.Length - 1] == array[i])
                    {
                        arrayReturn = array[i];
                        break;
                    }
                    arrayCollect[i] = array[i];
                }
                Console.WriteLine();
                for (int i = 0; i < arrayCollect.Length; i++)
                {
                    array[i] = arrayCollect[i];
                    Console.Write(array[i] + "\t");
                }
            }
            else
            {
                Console.WriteLine("Пустой Массив");
                return 0f;
            }
            Console.WriteLine();
            Console.WriteLine("Последний Элемент ");
            Console.WriteLine(arrayReturn);
            return arrayReturn;
        }

        // Push overload methods
        public static int Push(ref int[] array, int element)
        {
            var arrayCollect = new int[array.Length];
            if (array.Length > 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    arrayCollect[i] = array[i];
                }
                Console.WriteLine();
                array = new int[arrayCollect.Length + 1];
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
                array = new int[1];
                array[0] = element;
                Console.WriteLine("Добавленный Элемент " + array[0]);
            }
            return element;

        }
        public static string Push(ref string[] array, string element)
        {
            var arrayCollect = new string[array.Length];
            if (array.Length > 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    arrayCollect[i] = array[i];
                }
                Console.WriteLine();
                array = new string[arrayCollect.Length + 1];
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
                array = new string[1];
                array[0] = element;
                Console.WriteLine("Добавленный Элемент " + array[0]);
            }
            return element;

        }
        public static double Push(ref double[] array, double element)
        {
            var arrayCollect = new double[array.Length];
            if (array.Length > 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    arrayCollect[i] = array[i];
                }
                Console.WriteLine();
                array = new double[arrayCollect.Length + 1];
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
                array = new double[1];
                array[0] = element;
                Console.WriteLine("Добавленный Элемент " + array[0]);
            }
            return element;

        }
        public static decimal Push(ref decimal[] array, decimal element)
        {
            var arrayCollect = new decimal[array.Length];
            if (array.Length > 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    arrayCollect[i] = array[i];
                }
                Console.WriteLine();
                array = new decimal[arrayCollect.Length + 1];
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
                array = new decimal[1];
                array[0] = element;
                Console.WriteLine("Добавленный Элемент " + array[0]);
            }
            return element;

        }
        public static float Push(ref float[] array, float element)
        {
            var arrayCollect = new float[array.Length];
            if (array.Length > 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    arrayCollect[i] = array[i];
                }
                Console.WriteLine();
                array = new float[arrayCollect.Length + 1];
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
                array = new float[1];
                array[0] = element;
                Console.WriteLine("Добавленный Элемент " + array[0]);
            }
            return element;

        }

        // Shift overload methods.
        public static int Shift(ref int[] array)
        {
            var a = array[0];
            var arrayCollect = new int[array.Length-1];
            if (array.Length > 0)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    arrayCollect[i-1] = array[i];
                }
                Console.WriteLine();
                array = new int[arrayCollect.Length];
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
                array = new int[1];
                Console.WriteLine("Добавленный Элемент " + array[0]);
            }
            return a;
        }
        public static string Shift(ref string[] array)
        {
            var a = array[0];
            var arrayCollect = new string[array.Length-1];
            if (array.Length > 0)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    arrayCollect[i-1] = array[i];
                }
                Console.WriteLine();
                array = new string[arrayCollect.Length];
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
                array = new string[1];
                Console.WriteLine("Добавленный Элемент " + array[0]);
            }
            return a;
        }
        public static double Shift(ref double[] array)
        {
            var a = array[0];
            var arrayCollect = new double[array.Length-1];
            if (array.Length > 0)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    arrayCollect[i-1] = array[i];
                }
                Console.WriteLine();
                array = new double[arrayCollect.Length];
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
                array = new double[1];
                Console.WriteLine("Добавленный Элемент " + array[0]);
            }
            return a;
        }
        public static float Shift(ref float[] array)
        {
            var a = array[0];
            var arrayCollect = new float[array.Length-1];
            if (array.Length > 0)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    arrayCollect[i-1] = array[i];
                }
                Console.WriteLine();
                array = new float[arrayCollect.Length];
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
                array = new float[1];
                Console.WriteLine("Добавленный Элемент " + array[0]);
            }
            return a;
        }
        public static decimal Shift(ref decimal[] array)
        {
            var a = array[0];
            var arrayCollect = new decimal[array.Length-1];
            if (array.Length > 0)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    arrayCollect[i-1] = array[i];
                }
                Console.WriteLine();
                array = new decimal[arrayCollect.Length];
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
                array = new decimal[1];
                Console.WriteLine("Добавленный Элемент " + array[0]);
            }
            return a;
        }

        // UnShift overload methods.
        public static int UnShift(ref int[] array, int element)
        {
            var arrayCollect = new int[array.Length+1];
            if (array.Length > 0)
            {
                for (int i = 0; i < array.Length+1; i++)
                {
                    if (i == 0)
                    {
                        arrayCollect[i] = element;
                    }
                    else
                    {
                        arrayCollect[i] = array[i-1];
                    }
                }
                Console.WriteLine();
                array = new int[arrayCollect.Length];
                for (int i = 0; i < arrayCollect.Length; i++)
                {
                    array[i] = arrayCollect[i];
                    
                    Console.Write(array[i] + "\t");
                }
                Console.WriteLine();
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
                array = new int[arrayCollect.Length];
                for (int i = 0; i < arrayCollect.Length; i++)
                {
                    array[i] = arrayCollect[i];

                    Console.Write(array[i] + "\t");
                }
                Console.WriteLine("Добавленный Элемент " + element);
            }
            return element;
        }
        public static string UnShift(ref string[] array, string element)
        {
            var arrayCollect = new string[array.Length+1];
            if (array.Length > 0)
            {
                for (int i = 0; i < array.Length+1; i++)
                {
                    if (i == 0)
                    {
                        arrayCollect[i] = element;
                    }
                    else
                    {
                        arrayCollect[i] = array[i-1];
                    }
                }
                Console.WriteLine();
                array = new string[arrayCollect.Length];
                for (int i = 0; i < arrayCollect.Length; i++)
                {
                    array[i] = arrayCollect[i];
                    
                    Console.Write(array[i] + "\t");
                }
                Console.WriteLine();
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
                array = new string[arrayCollect.Length];
                for (int i = 0; i < arrayCollect.Length; i++)
                {
                    array[i] = arrayCollect[i];

                    Console.Write(array[i] + "\t");
                }
                Console.WriteLine("Добавленный Элемент " + element);
            }
            return element;
        }
        public static double UnShift(ref double[] array, double element)
        {
            var arrayCollect = new double[array.Length+1];
            if (array.Length > 0)
            {
                for (int i = 0; i < array.Length+1; i++)
                {
                    if (i == 0)
                    {
                        arrayCollect[i] = element;
                    }
                    else
                    {
                        arrayCollect[i] = array[i-1];
                    }
                }
                Console.WriteLine();
                array = new double[arrayCollect.Length];
                for (int i = 0; i < arrayCollect.Length; i++)
                {
                    array[i] = arrayCollect[i];
                    
                    Console.Write(array[i] + "\t");
                }
                Console.WriteLine();
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
                array = new double[arrayCollect.Length];
                for (int i = 0; i < arrayCollect.Length; i++)
                {
                    array[i] = arrayCollect[i];

                    Console.Write(array[i] + "\t");
                }
                Console.WriteLine("Добавленный Элемент " + element);
            }
            return element;
        }
        public static decimal UnShift(ref decimal[] array, decimal element)
        {
            var arrayCollect = new decimal[array.Length+1];
            if (array.Length > 0)
            {
                for (int i = 0; i < array.Length+1; i++)
                {
                    if (i == 0)
                    {
                        arrayCollect[i] = element;
                    }
                    else
                    {
                        arrayCollect[i] = array[i-1];
                    }
                }
                Console.WriteLine();
                array = new decimal[arrayCollect.Length];
                for (int i = 0; i < arrayCollect.Length; i++)
                {
                    array[i] = arrayCollect[i];
                    
                    Console.Write(array[i] + "\t");
                }
                Console.WriteLine();
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
                array = new decimal[arrayCollect.Length];
                for (int i = 0; i < arrayCollect.Length; i++)
                {
                    array[i] = arrayCollect[i];

                    Console.Write(array[i] + "\t");
                }
                Console.WriteLine("Добавленный Элемент " + element);
            }
            return element;
        }public static float UnShift(ref float[] array, float element)
        {
            var arrayCollect = new float[array.Length+1];
            if (array.Length > 0)
            {
                for (int i = 0; i < array.Length+1; i++)
                {
                    if (i == 0)
                    {
                        arrayCollect[i] = element;
                    }
                    else
                    {
                        arrayCollect[i] = array[i-1];
                    }
                }
                Console.WriteLine();
                array = new float[arrayCollect.Length];
                for (int i = 0; i < arrayCollect.Length; i++)
                {
                    array[i] = arrayCollect[i];
                    
                    Console.Write(array[i] + "\t");
                }
                Console.WriteLine();
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
                array = new float[arrayCollect.Length];
                for (int i = 0; i < arrayCollect.Length; i++)
                {
                    array[i] = arrayCollect[i];

                    Console.Write(array[i] + "\t");
                }
                Console.WriteLine("Добавленный Элемент " + element);
            }
            return element;
        }
    }
}
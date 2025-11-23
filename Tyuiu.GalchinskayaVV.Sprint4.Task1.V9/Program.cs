using System;
using Tyuiu.GalchinskayaVV.Sprint4.Task1.V9.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint4.Task1.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы                                                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан массив из 13 целых чисел [3;8]. Подсчитать произведение чётных      *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("***************************************************************************");

            int n = 13;
            int[] array = new int[n];

            Console.WriteLine("Введите 13 целых чисел от 3 до 8:");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"array[{i}] = ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            DataService ds = new DataService();
            int result = ds.Calculate(array);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Произведение чётных элементов массива = " + result);

            Console.ReadKey();
        }
    }
}

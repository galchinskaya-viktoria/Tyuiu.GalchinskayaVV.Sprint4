using System;
using Tyuiu.GalchinskayaVV.Sprint4.Task0.V15.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint4.Task0.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан массив {9, 8, 7, 6, 5, 7, 3, 2, 7, 3}.                              *");
            Console.WriteLine("* Найти произведение нечётных элементов массива.                          *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int result = ds.GetMultOddArrEl(array);

            Console.WriteLine("Произведение нечётных элементов массива = " + result);

            Console.ReadKey();
        }
    }
}

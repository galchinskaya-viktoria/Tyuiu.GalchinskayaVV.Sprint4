using System;
using Tyuiu.GalchinskayaVV.Sprint4.Task3.V3.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint4.Task3.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный массив 5x5. Подсчитать количество нечётных элементов.     *");
            Console.WriteLine("***************************************************************************");

            int[,] array =
            {
                { 9, 4, 5, 4, 8 },
                { 7, 6, 7, 7, 4 },
                { 4, 4, 3, 5, 6 },
                { 6, 5, 9, 4, 9 },
                { 9, 7, 8, 7, 7 }
            };

            Console.WriteLine("Исходный массив 5x5:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            DataService ds = new DataService();
            int result = ds.Calculate(array);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество нечётных элементов = " + result);

            Console.ReadKey();
        }
    }
}

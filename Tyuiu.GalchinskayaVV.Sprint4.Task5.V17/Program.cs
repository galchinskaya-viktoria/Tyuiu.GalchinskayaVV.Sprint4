using System;
using Tyuiu.GalchinskayaVV.Sprint4.Task5.V17.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint4.Task5.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Двумерный массив 5x5, случайные значения в диапазоне [-9;4].           *");
            Console.WriteLine("* Найти количество отрицательных элементов массива.                       *");
            Console.WriteLine("***************************************************************************");

            int rows = 5;
            int cols = 5;
            int[,] matrix = new int[rows, cols];
            Random rnd = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rnd.Next(-9, 5);
                }
            }

            Console.WriteLine("Исходный массив 5x5:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],3}");
                }
                Console.WriteLine();
            }

            DataService ds = new DataService();
            int result = ds.Calculate(matrix);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество отрицательных элементов = " + result);

            Console.ReadKey();
        }
    }
}

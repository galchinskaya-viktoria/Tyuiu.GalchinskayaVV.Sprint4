using System;
using Tyuiu.GalchinskayaVV.Sprint4.Task4.V11.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint4.Task4.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Двумерный массив 5x5 (значения с клавиатуры, от 5 до 8). Найти сумму   *");
            Console.WriteLine("* нечётных элементов массива.                                            *");
            Console.WriteLine("***************************************************************************");

            int rows = 5;
            int cols = 5;
            int[,] matrix = new int[rows, cols];

            Console.WriteLine("Введите элементы массива 5x5 (целые числа от 5 до 8):");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"[{i},{j}] = ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            DataService ds = new DataService();
            int result = ds.Calculate(matrix);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма нечётных элементов массива = " + result);

            Console.ReadKey();
        }
    }
}

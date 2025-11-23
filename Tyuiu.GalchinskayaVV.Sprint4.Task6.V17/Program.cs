using System;
using Tyuiu.GalchinskayaVV.Sprint4.Task6.V17.Lib;

namespace Tyuiu.ГalchinskayaVV.Sprint4.Task6.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (строковые)                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан массив [\"Python\",\"JavaScript\",\"Java\",\"C#\",\"Swift\",");
            Console.WriteLine("* \"Kotlin\",\"Ruby\"]. Используя класс Array посчитать количество строк *");
            Console.WriteLine("* длиной 6 символов.                                                      *");
            Console.WriteLine("***************************************************************************");

            string[] array = { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };

            Console.WriteLine("Исходный массив:");
            Array.ForEach(array, s => Console.Write(s + " "));
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int result = ds.Calculate(array);

            Console.WriteLine("Количество элементов длиной 6 = " + result);

            Console.ReadKey();
        }
    }
}

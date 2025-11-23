using Tyuiu.GalchinskayaVV.Sprint4.Task7.V24.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint4.Task7.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Гальчинская Виктория | ПКТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка \"651827384219648\". Преобразовать в матрицу 5x3 и найти     *");
            Console.WriteLine("* произведение всех чётных чисел.                                         *");
            Console.WriteLine("***************************************************************************");

            string str = "651827384219648";

            DataService ds = new DataService();
            int result = ds.Calculate(str);

            Console.WriteLine($"Произведение чётных чисел = {result}");

            Console.ReadKey();
        }
    }
}

using System;
using tyuiu.cources.programming.interfaces.Sprint4;
using Tyuiu.GalchinskayaVV.Sprint4.Task7.V24.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint4.Task7.V24.Lib
{
    public class DataService : ISprint4Task7V24
    {
        public int Calculate(string str)
        {
            int[,] matrix = new int[5, 3];
            int index = 0;

            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = int.Parse(str[index].ToString());
                    index++;
                }
            }

            int product = 1;

            
            foreach (int num in matrix)
            {
                if (num % 2 == 0)
                {
                    product *= num;
                }
            }

            return product;
        }

        public int Calculate(int n, int m, string value)
        {
            throw new NotImplementedException();
        }
    }
}

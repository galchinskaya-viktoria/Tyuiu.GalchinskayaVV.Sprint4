using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GalchinskayaVV.Sprint4.Task7.V24.Lib
{
    public class DataService : ISprint4Task7V24
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[index].ToString());
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
    }
}

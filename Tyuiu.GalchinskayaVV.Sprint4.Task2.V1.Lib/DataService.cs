using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GalchinskayaVV.Sprint4.Task2.V1.Lib
{
    public class DataService : ISprint4Task2V1
    {
        public int Calculate(int[] array)
        {
            int mult = 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    mult *= array[i];
                }
            }

            return mult;
        }
    }
}

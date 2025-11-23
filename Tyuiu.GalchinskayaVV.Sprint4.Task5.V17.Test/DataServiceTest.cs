using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint4.Task5.V17.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint4.Task5.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix =
            {
                { -1,  0,  2, -3,  4 },
                { -9,  4,  0,  1, -2 },
                {  3, -4, -5,  2,  0 },
                {  1,  2,  3,  4, -8 },
                { -9, -1,  0,  2,  3 }
            };

            int actual = ds.Calculate(matrix);
            int expected = 9;

            Assert.AreEqual(expected, actual);
        }
    }
}

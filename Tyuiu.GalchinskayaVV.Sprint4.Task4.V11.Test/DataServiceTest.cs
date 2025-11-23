using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint4.Task4.V11.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint4.Task4.V11.Test
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
                { 5, 7, 7, 8, 5 },
                { 6, 5, 6, 8, 6 },
                { 7, 6, 8, 8, 5 },
                { 7, 6, 7, 8, 6 },
                { 7, 6, 7, 7, 5 }
            };

            int actual = ds.Calculate(matrix);
            int expected = 81;

            Assert.AreEqual(expected, actual);
        }
    }
}

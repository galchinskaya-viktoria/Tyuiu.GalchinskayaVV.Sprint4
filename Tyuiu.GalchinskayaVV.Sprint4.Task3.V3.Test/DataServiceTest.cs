using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint4.Task3.V3.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint4.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();

            int[,] array =
            {
                { 9, 4, 5, 4, 8 },
                { 7, 6, 7, 7, 4 },
                { 4, 4, 3, 5, 6 },
                { 6, 5, 9, 4, 9 },
                { 9, 7, 8, 7, 7 }
            };

            int actual = ds.Calculate(array);
            int expected = 14;

            Assert.AreEqual(expected, actual);
        }
    }
}

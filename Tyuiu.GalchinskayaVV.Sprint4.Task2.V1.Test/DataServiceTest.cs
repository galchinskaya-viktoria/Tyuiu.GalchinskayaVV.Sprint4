using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint4.Task2.V1.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint4.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 2 };

            int actual = ds.Calculate(array);
            int expected = 768;

            Assert.AreEqual(expected, actual);
        }
    }
}

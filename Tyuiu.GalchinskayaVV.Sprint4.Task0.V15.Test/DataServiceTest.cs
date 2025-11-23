using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint4.Task0.V15.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint4.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMultOddArrEl()
        {
            DataService ds = new DataService();

            int[] array = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };

            int actual = ds.GetMultOddArrEl(array);
            int expected = 138915;

            Assert.AreEqual(expected, actual);
        }
    }
}

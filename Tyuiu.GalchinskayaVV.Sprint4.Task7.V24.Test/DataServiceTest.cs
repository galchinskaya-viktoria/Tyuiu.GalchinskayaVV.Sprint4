using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint4.Task7.V24.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint4.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckProductOfEvenDigits()
        {
            DataService ds = new DataService();

            string input = "651827384219648";

            int expected = 1;

            int[] evens =
            {
                6, 8, 2, 8, 4, 2, 6, 4, 8
            };

            foreach (int n in evens)
                expected *= n;

            int actual = ds.Calculate(input);

            Assert.AreEqual(expected, actual);
        }
    }
}

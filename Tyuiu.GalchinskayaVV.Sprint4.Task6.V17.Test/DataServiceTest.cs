using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint4.Task6.V17.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint4.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();

            string[] array = { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };

            int actual = ds.Calculate(array);
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }
    }
}

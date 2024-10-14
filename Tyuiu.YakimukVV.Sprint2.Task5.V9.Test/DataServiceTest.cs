using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YakimukVV.Sprint2.Task5.V9.Lib;

namespace Tyuiu.YakimukVV.Sprint2.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestJanuary()
        {
            DataService service = new DataService();
            string result = service.FindDateOfNextDay(31, 1);
            Assert.AreEqual("01.02", result);
        }

        [TestMethod]
        public void TestFebruary()
        {
            DataService service = new DataService();
            string result = service.FindDateOfNextDay(28, 2);
            Assert.AreEqual("01.03", result);
        }

        [TestMethod]
        public void TestNormalDay()
        {
            DataService service = new DataService();
            string result = service.FindDateOfNextDay(14, 3);
            Assert.AreEqual("15.03", result);
        }

        [TestMethod]
        public void TestApril()
        {
            DataService service = new DataService();
            string result = service.FindDateOfNextDay(30, 4);
            Assert.AreEqual("01.05", result);
        }

        [TestMethod]
        public void TestDayAfterAugust()
        {
            DataService service = new DataService();
            string result = service.FindDateOfNextDay(8, 9);
            Assert.AreEqual("09.09", result); 
        }
    }
}

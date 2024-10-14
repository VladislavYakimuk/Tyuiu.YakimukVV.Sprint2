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
            string result = service.FindDateOfNextDay(1, 31);
            Assert.AreEqual("01.02", result);
        }

        [TestMethod]
        public void TestFebruary()
        {
            DataService service = new DataService();
            string result = service.FindDateOfNextDay(2, 28);
            Assert.AreEqual("01.03", result);
        }

        [TestMethod]
        public void TestNormalDay()
        {
            DataService service = new DataService();
            string result = service.FindDateOfNextDay(3, 14);
            Assert.AreEqual("15.03", result);
        }

        [TestMethod]
        public void TestApril()
        {
            DataService service = new DataService();
            string result = service.FindDateOfNextDay(4, 30);
            Assert.AreEqual("01.05", result);
        }
    }
}

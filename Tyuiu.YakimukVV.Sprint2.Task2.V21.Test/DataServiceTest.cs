using Tyuiu.YakimukVV.Sprint2.Task2.V21.Lib;

namespace Tyuiu.YakimukVV.Sprint2.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.IsTrue(ds.CheckDotInShadedArea(3, 6));
        }

        [TestMethod]
        public void TestPointOutsideShadedArea()
        {
            DataService ds = new DataService();
            Assert.IsFalse(ds.CheckDotInShadedArea(1, 1));
        }

        [TestMethod]
        public void TestPointOnBorder()
        {
            DataService ds = new DataService();
            Assert.IsTrue(ds.CheckDotInShadedArea(12, 7));
        }
    }
}

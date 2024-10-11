using Tyuiu.YakimukVV.Sprint2.Task4.V4.Lib;

namespace Tyuiu.YakimukVV.Sprint2.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 5;
            double expected = Math.Round(Math.Sin(x) + 2 * y, 3);

            double result = ds.Calculate(x, y);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCalculate2()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            double expected = Math.Round(Math.Cos(y) + 2 * x * y, 3);

            double result = ds.Calculate(x, y);

            Assert.AreEqual(expected, result);
        }
    }
}

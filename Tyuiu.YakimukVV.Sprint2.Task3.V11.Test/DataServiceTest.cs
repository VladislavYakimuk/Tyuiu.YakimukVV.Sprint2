using Microsoft.VisualStudio.TestPlatform.TestHost;
using Tyuiu.YakimukVV.Sprint2.Task3.V11.Lib;
namespace Tyuiu.YakimukVV.Sprint2.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 5;
            double expected = x + Math.Pow((x - 15) / (x - 19), x);
            double actual = ds.Calculate(x);
            Assert.AreEqual(Math.Round(expected, 3), actual);
        }

        [TestMethod]
        public void TestXEqualsZero()
        {
            DataService ds = new DataService();
            double x = 0;
            double expected = (Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12);
            double actual = ds.Calculate(x);
            Assert.AreEqual(Math.Round(expected, 3), actual);
        }

        [TestMethod]
        public void TestXEqualsMinus15()
        {
            DataService ds = new DataService();
            double x = -10;
            double expected = Math.Pow(1 + (1 / Math.Pow(x, 2)), x);
            double actual = ds.Calculate(x);
            Assert.AreEqual(Math.Round(expected, 3), Math.Round(actual, 3));
        }

        [TestMethod]
        public void TestXLessThanMinus15()
        {
            DataService ds = new DataService();
            double x = -20;
            double expected = x + 10 * x - (1 / x);
            double actual = ds.Calculate(x);
            Assert.AreEqual(Math.Round(expected, 3), Math.Round(actual, 3));
        }
    }
}
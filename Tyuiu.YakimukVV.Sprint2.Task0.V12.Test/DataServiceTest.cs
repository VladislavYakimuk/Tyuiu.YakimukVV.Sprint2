using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YakimukVV.Sprint2.Task0.V12.Lib;
using System.Linq;

namespace Tyuiu.YakimukVV.Sprint2.Task0.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperation()
        {

            DataService ds = new DataService();
            int x = 1095;
            int y = 475;
            bool[] expected = new bool[] { false, true, false, true, false, true };


            bool[] actual = ds.GetCompareOperations(x, y);


            Assert.AreEqual(expected.Length, actual.Length, "Arrays do not have the same length.");
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], $"Element at index {i} is not equal.");
            }
        }
    }
}
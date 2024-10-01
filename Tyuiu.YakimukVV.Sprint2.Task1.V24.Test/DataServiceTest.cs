using Tyuiu.YakimukVV.Sprint2.Task1.V24.Lib;
namespace Tyuiu.YakimukVV.Sprint2.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 325, b = 325, c = 242, d = 324;
            bool[] result = ds.GetLogicOperations(a, b, c, d);
            bool[] expected = { true, true, true, true, false, true };
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
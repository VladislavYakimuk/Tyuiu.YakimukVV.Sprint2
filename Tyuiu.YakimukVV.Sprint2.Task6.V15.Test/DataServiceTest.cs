using Tyuiu.YakimukVV.Sprint2.Task6.V15.Lib;
namespace Tyuiu.YakimukVV.Sprint2.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestFindDayName()
        {
            DataService service = new DataService();

            Assert.AreEqual("Понедельник", service.FindDayName(1));  // 1 января
            Assert.AreEqual("Вторник", service.FindDayName(2));      // 2 января
            Assert.AreEqual("Воскресенье", service.FindDayName(7));  // 7 января
            Assert.AreEqual("Понедельник", service.FindDayName(8));  // 8 января
        }
    }
}

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

            Assert.AreEqual("�����������", service.FindDayName(1));  // 1 ������
            Assert.AreEqual("�������", service.FindDayName(2));      // 2 ������
            Assert.AreEqual("�����������", service.FindDayName(7));  // 7 ������
            Assert.AreEqual("�����������", service.FindDayName(8));  // 8 ������
        }
    }
}

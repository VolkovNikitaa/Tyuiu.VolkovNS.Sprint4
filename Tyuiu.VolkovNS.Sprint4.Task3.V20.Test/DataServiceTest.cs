using Tyuiu.VolkovNS.Sprint4.Task3.V20.Lib;

namespace Tyuiu.VolkovNS.Sprint4.Task3.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 2, 4, 4, 7, 2, 5, 4, 3, 3, 4 };
            int sum = 1024;
            Assert.AreEqual(ds.Calculate(array), sum);
        }
    }
}

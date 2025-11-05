using Tyuiu.VolkovNS.Sprint4.Task4.V11.Lib;

namespace Tyuiu.VolkovNS.Sprint4.Task4.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] { { 8, 7, 7, 8, 5 }, { 4, 3, 5, 3, 6 }, { 5, 3, 8, 6, 3 }, { 6, 3, 8, 5, 4 }, { 3, 6, 8, 3, 4 } };
            int sum = 1024;
            Assert.AreEqual(ds.Calculate(array), sum);
        }
    }
}

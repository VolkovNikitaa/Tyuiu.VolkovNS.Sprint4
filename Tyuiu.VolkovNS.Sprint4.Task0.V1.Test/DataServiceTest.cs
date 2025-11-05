using System.Diagnostics.CodeAnalysis;
using Tyuiu.VolkovNS.Sprint4.Task0.V1.Lib;

namespace Tyuiu.VolkovNS.Sprint4.Task0.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 6, 4, 3, 2, 1, 0, 9, 8, 7, 5 };
            int sum = 20;
            Assert.AreEqual(ds.GetSumEvenArrEl(array), sum);
        }
    }
}

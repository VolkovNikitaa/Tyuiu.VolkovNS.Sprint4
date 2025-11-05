using System.Diagnostics.CodeAnalysis;
using Tyuiu.VolkovNS.Sprint4.Task6.V25.Lib;

namespace Tyuiu.VolkovNS.Sprint4.Task6.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] array = { "Теннис", "Футбол", "Крикет", "Баскетбол", "Бейсбол", "Регби", "Хоккей" };
            int sum = 2;
            Assert.AreEqual(ds.Calculate(array), sum);
        }
    }
}

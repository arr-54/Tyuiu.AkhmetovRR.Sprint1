using Tyuiu.AkhmetovRR.Sprint1.Task0.V26.Lib;

namespace Tyuiu.AkhmetovRR.Sprint1.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double result = ds.Calculate();

            Assert.AreEqual(4 * 5 / 2.0 - 18 / 2.0 / 3.0, result);
        }
    }
}
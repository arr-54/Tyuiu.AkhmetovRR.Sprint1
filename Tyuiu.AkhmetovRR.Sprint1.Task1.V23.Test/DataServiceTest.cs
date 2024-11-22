using Tyuiu.AkhmetovRR.Sprint1.Task1.V23.Lib;

namespace Tyuiu.AkhmetovRR.Sprint1.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 10;
            double a = 17;
            DataService ds = new DataService();
            double result = ds.Calculate(x, a);
            Assert.AreEqual((x * Math.PI) / (2 * a), result);
        }
    }
}
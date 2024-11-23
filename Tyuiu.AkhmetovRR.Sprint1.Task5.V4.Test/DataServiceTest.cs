using Tyuiu.AkhmetovRR.Sprint1.Task5.V4.Lib;
namespace Tyuiu.AkhmetovRR.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double k = 13257;
            DataService ds = new DataService();
            int result = ds.Calculate(k);
            Assert.AreEqual(Math.Round(k / 3600) - 1, result);
        }
    }
}
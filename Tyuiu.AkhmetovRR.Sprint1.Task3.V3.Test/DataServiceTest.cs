using Tyuiu.AkhmetovRR.Sprint1.Task3.V5.Lib;
namespace Tyuiu.AkhmetovRR.Sprint1.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 12;
            double b = 13;
            double c = 16;
            DataService ds = new DataService();
            double result = ds.Calculate(a, b, c);
            Assert.AreEqual(a * b * c, result);
        }
    }
}
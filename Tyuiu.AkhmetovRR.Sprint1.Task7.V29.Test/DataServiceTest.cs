using Tyuiu.AkhmetovRR.Sprint1.Task7.V29.Lib;
namespace Tyuiu.AkhmetovRR.Sprint1.Task7.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 18;
            double y = 16;
            DataService ds = new DataService();
            double result = ds.Calculate(x, y);
            Assert.AreEqual(x - (Math.Cos(Math.Pow(x, 3)) / ((x * y) - 3)) + (Math.Sin(Math.Pow(x, 5)) / ((x * y) + 5)), result);
        }
    }
}
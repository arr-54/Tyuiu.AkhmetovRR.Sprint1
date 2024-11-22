using Tyuiu.AkhmetovRR.Sprint1.Task6.V1.Lib;
namespace Tyuiu.AkhmetovRR.Sprint1.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            char x = '1';
            DataService ds = new DataService();
            double result = ds.Calculate(x);
            Assert.AreEqual(x, result);
        }
    }
}
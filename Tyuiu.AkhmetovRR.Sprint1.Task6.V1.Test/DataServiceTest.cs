using Tyuiu.AkhmetovRR.Sprint1.Task6.V1.Lib;
namespace Tyuiu.AkhmetovRR.Sprint1.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string x = "1";
            DataService ds = new DataService();
            string result = ds.SymbolCode(x);
            Assert.AreEqual(x, result);
        }
    }
}
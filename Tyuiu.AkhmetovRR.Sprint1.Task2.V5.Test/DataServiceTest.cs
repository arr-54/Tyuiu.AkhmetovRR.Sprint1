using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AkhmetovRR.Sprint1.Task2.V5.Lib;

namespace Tyuiu.AkhmetovRR.Sprint1.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 9;
            DataService ds = new DataService();
            double result = ds.Calculate(a);
            Assert.AreEqual(6 * Math.Pow(a, 2), result);
        }
    }
}
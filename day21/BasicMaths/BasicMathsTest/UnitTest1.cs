using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicMaths1;
namespace BasicMathsTest
{
    [TestClass]
    public class BasicMathsTesting
    {
        [TestMethod]
        public void TestMethod1()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Add(10, 10);
            Assert.AreEqual(res, 20);
        }
        [TestMethod]
        public void Test_SubstractMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Subtract(10, 10);
            Assert.AreEqual(res, 0);
        }
        [TestMethod]
        public void Test_DivideMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Divide(10, 5);
            Assert.AreEqual(res, 2);
        }
        [TestMethod]
        public void Test_MultiplyMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Multiply(10, 10);
            Assert.AreEqual(res, 100);
        }
    }
}
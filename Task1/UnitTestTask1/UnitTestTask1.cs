using System;
using logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTask1
{
    [TestClass]
    public class UnitTestTask1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double act = Mathematic.GetRoot(1, 10);
            double exp = Math.Pow(1, 0.1);
            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        public void TestMethod2()
        {
            double act = Mathematic.GetRoot(0, 10);
            double exp = Math.Pow(0, 0.1);
            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        public void TestMethod3()
        {
            double act = Mathematic.GetRoot(1, 0);
            double exp = Math.Pow(1, 0);
            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        public void TestMethod4()
        {
            double act = Mathematic.GetRoot(0, 0);
            double exp = Math.Pow(0, 0);
            Assert.AreEqual(exp, act);
        }
    }
}

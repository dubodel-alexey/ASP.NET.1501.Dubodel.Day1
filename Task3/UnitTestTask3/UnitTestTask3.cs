using System;
using System.Globalization;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTask3
{
    [TestClass]
    public class UnitTestTask3
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 10;
            string act = String.Format(new HexNumberFormat(), "{0:HEX}", x);
            Assert.AreEqual("A", act);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string x = "A";
            string act = String.Format(new HexNumberFormat(), "{0:HEX}", x);
            Assert.AreEqual("A", act);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int x = 10;
            string act = String.Format(new HexNumberFormat(), "{0:hex}", x);
            Assert.AreEqual("a", act);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Int64 x = 10;
            string act = String.Format(new HexNumberFormat(), "{0:HEX}", x);
            Assert.AreEqual("A", act);
        }

        [TestMethod]
        public void TestMethod5()
        {
            double balance = 16.34;
            string act = String.Format(new HexNumberFormat(), "{0:C2}", balance);
            Assert.AreEqual("16,34 р.", act);
        }

        [TestMethod]
        public void TestMethod6()
        {
            double balance = 16.34;
            string act = String.Format(new HexNumberFormat(), "{0:HEX}", balance);
            Assert.AreEqual("16,34", act);
        }

        [TestMethod]
        public void TestMethod7()
        {
            int x = 10;
            string act = String.Format(new HexNumberFormat(), "{0:C2}", x);
            Assert.AreEqual("10,00 р.", act);
        }
    }
}

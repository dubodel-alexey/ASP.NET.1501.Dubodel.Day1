using System;
using System.Globalization;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace logicTests
{
    [TestClass]
    public class HexNumberFormatTests
    {
        [TestMethod]
        public void StringFormatTestMethod1()
        {
            int x = 10;
            string act = String.Format(new HexNumberFormat(), "{0:HEX}", x);
            Assert.AreEqual("A", act);
        }

        [TestMethod]
        public void StringFormatTestMethod2()
        {
            string x = "A";
            string act = String.Format(new HexNumberFormat(), "{0:HEX}", x);
            Assert.AreEqual("A", act);
        }

        [TestMethod]
        public void StringFormatTestMethod3()
        {
            int x = -1014;
            string act = String.Format(new HexNumberFormat(), "{0:hex}", x);
            Assert.AreEqual("-3f6", act);
        }

        [TestMethod]
        public void StringFormatTestMethod4()
        {
            Int64 x = 10;
            string act = String.Format(new HexNumberFormat(), "{0:HEX}", x);
            Assert.AreEqual("A", act);
        }

        [TestMethod]
        public void StringFormatTestMethod5()
        {
            double balance = 16.34;
            string act = String.Format(new HexNumberFormat(), "{0:C2}", balance);
            string expected = string.Format(CultureInfo.CurrentCulture, "{0:C2}", balance);
            Assert.AreEqual(expected, act);
        }

        [TestMethod]
        public void StringFormatTestMethod6()
        {
            double balance = 16.34;
            string actual = String.Format(new HexNumberFormat(), "{0:HEX}", balance);
            string expected = String.Format("{0}", balance);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringFormatTestMethod7()
        {
            int x = 10;
            string actual = String.Format(new HexNumberFormat(), "{0:C2}", x);
            string expected = String.Format(CultureInfo.CurrentCulture, "{0:C2}", x);
            Assert.AreEqual(expected, actual);
        }
    }
}

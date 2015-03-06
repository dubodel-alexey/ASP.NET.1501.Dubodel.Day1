using System;
using logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace logicTests
{
    [TestClass()]
    public class MathematicTests
    {
        [TestMethod()]
        public void GreatestCommonDivisorSteinTestTwoNumbers()
        {
            long x = 10, y = 100;
            long actual = Mathematic.GreatestCommonDivisorStein(x, y);
            long expected = 10;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GreatestCommonDivisorSteinTestTwoNumbers1()
        {
            long x = 0, y = 100;
            long actual = Mathematic.GreatestCommonDivisorStein(x, y);
            long expected = 100;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GreatestCommonDivisorSteinTestTwoNumbers2()
        {
            long x = 0, y = -10;
            long actual = Mathematic.GreatestCommonDivisorStein(x, y);
            long expected = 10;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GreatestCommonDivisorSteinTestTwoNumbers3()
        {
            long x = 19, y = 151;
            long actual = Mathematic.GreatestCommonDivisorStein(x, y);
            long expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GreatestCommonDivisorSteinTestThreeNumbers()
        {
            long x = 10, y = 100, z = 5;
            var time = new TimeSpan();
            long actual = Mathematic.GreatestCommonDivisorStein(ref time, x, y, z);
            long expected = 5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GreatestCommonDivisorSteinTestThreeNumbers1()
        {
            long x = -10, y = 0, z = -5;
            var time = new TimeSpan();
            long actual = Mathematic.GreatestCommonDivisorStein(ref time, x, y, z);
            long expected = 5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GreatestCommonDivisorEuclideanTestTwoNumbers()
        {
            long x = 10, y = 100;
            long actual = Mathematic.GreatestCommonDivisorStein(x, y);
            long expected = 10;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GreatestCommonDivisorEuclideanTestTwoNumbers1()
        {
            long x = 0, y = 100;
            long actual = Mathematic.GreatestCommonDivisorStein(x, y);
            long expected = 100;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GreatestCommonDivisorEuclideanTestTwoNumbers2()
        {
            long x = 0, y = -10;
            long actual = Mathematic.GreatestCommonDivisorStein(x, y);
            long expected = 10;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GreatestCommonDivisorEuclideanTestTwoNumbers3()
        {
            long x = 19, y = 151;
            long actual = Mathematic.GreatestCommonDivisorStein(x, y);
            long expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GreatestCommonDivisorEuclideanTestThreeNumbers()
        {
            long x = 10, y = 100, z = 5;
            var time = new TimeSpan();
            long actual = Mathematic.GreatestCommonDivisorStein(ref time, x, y, z);
            long expected = 5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GreatestCommonDivisorEuclideanTestThreeNumbers1()
        {
            long x = -10, y = 0, z = -5;
            var time = new TimeSpan();
            long actual = Mathematic.GreatestCommonDivisorStein(ref time, x, y, z);
            long expected = 5;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void GetRootTest()
        {
            double act = Mathematic.GetRoot(1, 10);
            double exp = Math.Pow(1, 0.1);
            Assert.AreEqual(exp, act);
        }

        [TestMethod()]
        public void GetRootTest1()
        {
            double act = Mathematic.GetRoot(0, 10);
            double exp = Math.Pow(0, 0.1);
            Assert.AreEqual(exp, act);
        }

        [TestMethod()]
        public void GetRootTest2()
        {
            double act = Mathematic.GetRoot(1, 0);
            double exp = Math.Pow(1, 0);
            Assert.AreEqual(exp, act);
        }

        [TestMethod()]
        public void GetRootTest3()
        {
            double act = Mathematic.GetRoot(0, 0);
            double exp = Math.Pow(0, 0);
            Assert.AreEqual(exp, act);
        }
    }
}

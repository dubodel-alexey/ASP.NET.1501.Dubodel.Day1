using logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTask2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool testResult = true;
            var act = new[]
            {
                new[] {2, 2},
                new[] {6, 7, 12212},
                new[] {2, 2, 2}
            };

            SortingClass.SortByElementsSum(act, false);

            var exp = new[]
            {
                new[] {6, 7, 12212},
                new[] {2, 2, 2},
                new[] {2, 2}
            };

            for (int i = 0; i < act.Length; i++)
            {
                for (int j = 0; j < act[i].Length; j++)
                {
                    testResult &= act[i][j].Equals(exp[i][j]);
                }
            }

            Assert.AreEqual(true, testResult);
        }

        [TestMethod]
        public void TestMethod2()
        {
            bool testResult = true;
            var act = new[]
            {
                new[] {2, 3},
                new[] {6, 7, 12212},
                new[] {10, 1}
            };

            SortingClass.SortByMinElements(act, true);

            var exp = new[]
            {
                new[] {10, 1},
                new[] {2, 3},
                new[] {6, 7, 12212}
            };

            for (int i = 0; i < act.Length; i++)
            {
                for (int j = 0; j < act[i].Length; j++)
                {
                    testResult &= act[i][j].Equals(exp[i][j]);
                }
            }

            Assert.AreEqual(true, testResult);
        }

        [TestMethod]
        public void TestMethod3()
        {
            bool testResult = true;
            var act = new[]
            {
                new[] {2, 2},
                new[] {6, 7, 12212},
                new[] {2, 3, 2}
            };

            SortingClass.SortByMaxElements(act, false);

            var exp = new[]
            {
                new[] {6, 7, 12212},
                new[] {2, 3, 2},
                new[] {2, 2}
            };

            for (int i = 0; i < act.Length; i++)
            {
                for (int j = 0; j < act[i].Length; j++)
                {
                    testResult &= act[i][j].Equals(exp[i][j]);
                }
            }

            Assert.AreEqual(true, testResult);
        }
    }
}
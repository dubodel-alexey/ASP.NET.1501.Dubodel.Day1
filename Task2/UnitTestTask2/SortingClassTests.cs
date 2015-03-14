using System;
using logic;
using logic.Comparer;
using logic.Sorter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTask2
{
    [TestClass]
    public class SortingClassTests
    {

        private int[][] actual =
        {
            new[] {1, 1},
            null,
            new[] {1, 2, 3},
            new [] {5}
        };


        [TestMethod]
        public void BubleSortSumDirectComparer()
        {
            var expected = new[]
            {
                null,
                actual[0],
                actual[3],
                actual[2]
            };

            var sorter = new BubbleSorter();
            var comparer = new SumDirectComparer();

            actual.Sort(comparer, sorter);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BubleSortMaxAbsDirectComparer()
        {
            var expected = new[]
            {
                null,
                actual[0],
                actual[2],
                actual[3]
            };

            var sorter = new BubbleSorter();
            var comparer = new MaxAbsDirectComparer();

            actual.Sort(comparer, sorter);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SortSorterArgumentNullException()
        {
            BubbleSorter sorter = null;
            var comparer = new MaxAbsDirectComparer();
            actual.Sort(comparer, sorter);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SortComparerArgumentNullException()
        {
            var sorter = new BubbleSorter();
            IComparer comparer = null;
            actual.Sort(comparer, sorter);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SortArrayArgumentNullException()
        {
            var sorter = new BubbleSorter();
            IComparer comparer = null;
            SortingClass.Sort(null, comparer, sorter);
        }
    }
}
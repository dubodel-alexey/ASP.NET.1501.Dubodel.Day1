using System;
using System.Linq;
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


        private Func<int[], int[], int> LengthDecrease = ((firstArray, secondArray) =>
        {
            if (firstArray == null && secondArray == null) return 0;
            if (firstArray != null && secondArray == null) return -1;
            if (firstArray == null) return 1;

            return secondArray.Length.CompareTo(firstArray.Length);
        });



        [TestMethod]
        public void BubleSortSumEncreaseInterface()
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
        public void BubleSortMaxAbsEncreaseInterface()
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
        public void InterfaceSortSorterArgumentNullException()
        {
            BubbleSorter sorter = null;
            var comparer = new MaxAbsDirectComparer();
            actual.Sort(comparer, sorter);
        }


        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void InterfaceSortComparerArgumentNullException()
        {
            var sorter = new BubbleSorter();
            IComparer comparer = null;
            actual.Sort(comparer, sorter);
        }


        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void InterfaceSortArrayArgumentNullException()
        {
            var sorter = new BubbleSorter();
            IComparer comparer = null;
            SortingClass.Sort(null, comparer, sorter);
        }


        [TestMethod]
        public void BubleSortSumEncreaseDelegate()
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

            actual.Sort(comparer.Compare, sorter);

            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void BubleSortMaxAbsEncreaseDelegate()
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

            actual.Sort(comparer.Compare, sorter);

            CollectionAssert.AreEqual(expected, actual);
        } 
        

        [TestMethod]
        public void BubleSortLengthDecreaseDelegate()
        {
            var expected = new[]
            {
                
                actual[2],
                actual[0],
                actual[3],
                null,
            };

            var sorter = new BubbleSorter();
            actual.Sort(LengthDecrease, sorter);

            CollectionAssert.AreEqual(expected, actual);
        }

    }
}
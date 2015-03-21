using System;

namespace logic
{
    public static class SortingClass
    {
        public static void Sort(this int[][] targetArray, IComparer comparer, ISorter sorter)
        {
            if (targetArray == null)
            {
                throw new ArgumentNullException("targetArray");
            }
            if (comparer == null)
            {
                throw new ArgumentNullException("comparer");
            }
            if (sorter == null)
            {
                throw new ArgumentNullException("sorter");
            }
            sorter.Sort(targetArray, comparer.Compare);
        }

        public static void Sort(this int[][] targetArray, Func<int[], int[], int> compare, ISorter sorter)
        {
            if (targetArray == null)
            {
                throw new ArgumentNullException("targetArray");
            }
            if (compare == null)
            {
                throw new ArgumentNullException("compare");
            }
            if (sorter == null)
            {
                throw new ArgumentNullException("sorter");
            }
            sorter.Sort(targetArray, compare);
        }
    }
}

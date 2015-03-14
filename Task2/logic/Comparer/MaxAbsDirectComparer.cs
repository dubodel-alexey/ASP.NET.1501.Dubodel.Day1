using System;
using System.Linq;

namespace logic.Comparer
{
    public class MaxAbsDirectComparer : IComparer
    {
        public int Compare(int[] firstArray, int[] secondArray)
        {
            if (firstArray == null && secondArray == null) return 0;
            if (firstArray != null && secondArray == null) return 1;
            if (firstArray == null && secondArray != null) return -1;

            if (firstArray.Length == 0 && secondArray.Length == 0) return 0;
            if (firstArray.Length != 0 && secondArray.Length == 0) return 1;
            if (firstArray.Length == 0 && secondArray.Length != 0) return -1;

            var firstMaxValue = FindMaxAbs(firstArray);
            var secondMaxValue = FindMaxAbs(secondArray);

            return firstMaxValue.CompareTo(secondMaxValue);
        }

        private static int FindMaxAbs(int[] array)
        {
            int maxAbsValue = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) > maxAbsValue)
                {
                    maxAbsValue = Math.Abs(array[i]);
                }
            }
            return maxAbsValue;
        }
    }
}

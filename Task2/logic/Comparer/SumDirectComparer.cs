using System.Linq;

namespace logic.Comparer
{
    public class SumDirectComparer : IComparer
    {
        public int Compare(int[] firstArray, int[] secondArray)
        {
            if (firstArray == null && secondArray == null) return 0;
            if (firstArray != null && secondArray == null) return 1;
            if (firstArray == null && secondArray != null) return -1;

            if (firstArray.Length == 0 && secondArray.Length == 0) return 0;
            if (firstArray.Length != 0 && secondArray.Length == 0) return 1;
            if (firstArray.Length == 0 && secondArray.Length != 0) return -1;

            var firstMaxValue = firstArray.Sum();
            var secondMaxValue = secondArray.Sum();

            return firstMaxValue.CompareTo(secondMaxValue);
        }
    }
}

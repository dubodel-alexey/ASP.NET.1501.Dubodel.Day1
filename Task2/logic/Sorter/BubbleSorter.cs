using System;

namespace logic.Sorter
{
    public class BubbleSorter : ISorter
    {
        public void Sort(int[][] targetArray, Func<int[], int[], int> compare)
        {
            if (targetArray == null)
            {
                throw new ArgumentNullException("targetArray");
            }
            if (compare == null)
            {
                throw new ArgumentNullException("compare");
            }

            for (int i = 0; i < targetArray.Length; i++)
            {
                for (int j = i + 1; j < targetArray.Length; j++)
                {
                    if (compare(targetArray[i], targetArray[j]) > 0)
                    {
                        var temp = targetArray[i];
                        targetArray[i] = targetArray[j];
                        targetArray[j] = temp;
                    }
                }
            }
        }
    }
}

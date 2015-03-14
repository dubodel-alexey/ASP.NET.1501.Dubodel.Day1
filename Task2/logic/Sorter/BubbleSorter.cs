using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic.Sorter
{
    public class BubbleSorter : ISorter
    {
        public void Sort(int[][] targetArray, IComparer comparer)
        {
            if (targetArray == null)
            {
                throw new ArgumentNullException("targetArray");
            }
            if (comparer == null)
            {
                throw new ArgumentNullException("comparer");
            }

            for (int i = 0; i < targetArray.Length; i++)
            {
                for (int j = i + 1; j < targetArray.Length; j++)
                {
                    if (comparer.Compare(targetArray[i], targetArray[j]) > 0)
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

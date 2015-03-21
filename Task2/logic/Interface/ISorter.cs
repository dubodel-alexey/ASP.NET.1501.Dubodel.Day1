using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    public interface ISorter
    {
        void Sort(int[][] array, Func<int[], int[], int> compare);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    public  interface IComparer
    {
        int Compare(int[] firstArray, int[] secondArray);
    }
}

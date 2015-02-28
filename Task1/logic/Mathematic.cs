using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    public static class Mathematic
    {
        public static double GetRoot(double number, int power)
        {
            if (power == 0) return 1;
            if (Math.Abs(number) < 0.0001) return 0;

            double eps = 1e-20;
            double previousResult, newResult = 1;
            do
            {
                previousResult = newResult;
                newResult = (1.0 / power) * ((power - 1) * previousResult + number / Math.Pow(previousResult, power - 1));
            } while (Math.Abs(previousResult - newResult) >= eps);

            return newResult;
        }
    }
}

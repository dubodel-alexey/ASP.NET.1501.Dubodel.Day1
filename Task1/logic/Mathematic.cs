using System;
using System.Diagnostics;

namespace logic
{
    public static class Mathematic
    {
        public static double GetRoot(double number, int power)
        {
            if (power == 0) return 1;
            if (Math.Abs(number) < double.Epsilon) return 0;

            double previousResult, newResult = 1;
            do
            {
                previousResult = newResult;
                newResult = (1.0 / power) * ((power - 1) * previousResult + number / Math.Pow(previousResult, power - 1));
            } while (Math.Abs(previousResult - newResult) >= double.Epsilon);

            return newResult;
        }

        public static long GreatestCommonDivisorEuclidean(long firstNumber, long secondNumber)
        {
            firstNumber = Math.Abs(firstNumber);
            secondNumber = Math.Abs(secondNumber);

            if (firstNumber == 0) return secondNumber;
            if (secondNumber == 0) return firstNumber;

            long temp;

            if (firstNumber < secondNumber)
            {
                temp = firstNumber;
                firstNumber = secondNumber;
                secondNumber = temp;
            }

            while (secondNumber != 0)
            {
                temp = secondNumber;
                secondNumber = firstNumber % secondNumber;
                firstNumber = temp;
            }

            return firstNumber;
        }

        public static long GreatestCommonDivisorEuclidean(ref long elapsedTicks, long firstNumber, long secondNumber)
        {
            var interval = new Stopwatch();
            interval.Start();
            long result = GreatestCommonDivisorEuclidean(firstNumber, secondNumber);
            interval.Stop();
            elapsedTicks = interval.ElapsedTicks;
            return result;
        }

        public static long GreatestCommonDivisorEuclidean(ref long elapsedTicks, params long[] numbers)
        {
            var interval = new Stopwatch();
            interval.Start();
            long result = GreatestCommonDivisorEuclidean(numbers[0], numbers[1]);
            for (int i = 2; i < numbers.Length; i++)
            {
                result = GreatestCommonDivisorEuclidean(result, numbers[i]);
            }

            interval.Stop();
            elapsedTicks = interval.ElapsedTicks;
            return result;
        }

        public static long GreatestCommonDivisorStein(long firstNumber, long secondNumber)
        {
            int shift = 0;

            firstNumber = Math.Abs(firstNumber);
            secondNumber = Math.Abs(secondNumber);

            /* GCD(0,v) == v; GCD(u,0) == u, GCD(0,0) == 0 */
            if (firstNumber == 0) return secondNumber;
            if (secondNumber == 0) return firstNumber;
            
            // shift - greatest power of 2 of both numbers
            while ((firstNumber % 2 == 0) && (secondNumber % 2 == 0))
            {
                firstNumber >>= 1;
                secondNumber >>= 1;
                shift++;
            }

            while ((firstNumber & 1) == 0)
                firstNumber >>= 1;

            // From here on, firstNumber is always odd. 
            do
            {
                // make secondNumber odd too, because gcd(n,m) == gcd(n, m/2), if n - odd, m - even
                while ((secondNumber & 1) == 0)
                    secondNumber >>= 1;

                if (firstNumber > secondNumber)
                {
                    long t = secondNumber;
                    secondNumber = firstNumber;
                    firstNumber = t;
                }

                secondNumber -= firstNumber;
            } while (secondNumber != 0);

            /* restore common factors of 2 */
            return firstNumber << shift;
        }

        public static long GreatestCommonDivisorStein(ref long elapsedTicks, long firstNumber, long secondNumber)
        {
            var interval = new Stopwatch();
            interval.Start();
            long result = GreatestCommonDivisorStein(firstNumber, secondNumber);
            interval.Stop();
            elapsedTicks = interval.ElapsedTicks;
            return result;
        }

        public static long GreatestCommonDivisorStein(ref long elapsedTicks, params long[] numbers)
        {
            var interval = new Stopwatch();
            interval.Start();
            long result = GreatestCommonDivisorStein(numbers[0], numbers[1]);
            for (int i = 2; i < numbers.Length; i++)
            {
                result = GreatestCommonDivisorStein(result, numbers[i]);
            }

            elapsedTicks = interval.ElapsedTicks;
            return result;
        }
    }
}

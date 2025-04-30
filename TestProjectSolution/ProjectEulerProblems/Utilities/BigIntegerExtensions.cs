using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems.Utilities
{
    /// <summary>
    /// Class containing methods that extend the computational utility of BigIntegers.
    /// </summary>
    public static class BigIntegerExtensions
    {
        /// <summary>
        /// Calculates the integer square root of a non-negative BigInteger; i.e. the greatest integer less than or equal to the true square root of the input.
        /// </summary>
        /// <param name="num">Argument of the square root function.</param>
        /// <returns>The integer square root of <paramref name="num"/>.</returns>
        /// <remarks>
        /// Uses binary search to efficiently find the floor of the square root.
        /// Should converge in O(log num) steps.
        /// </remarks>
        public static BigInteger IntegerSqrt(BigInteger num)
        {
            if (num < 0)
            {
                return -1;
            }

            if (num == 0 || num == 1)
            {
                return num;
            }

            BigInteger low = 0;
            BigInteger high = num;

            while (low <= high)
            {
                BigInteger mid = (low + high) / 2;
                BigInteger midSquared = mid * mid;

                if (midSquared == num)
                {
                    return mid;
                }
                else if (midSquared < num)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return high;
        }

        /// <summary>
        /// Calculates the integer floor of the n-th root of a non-negative BigInteger.
        /// For example, IntegerRoot(27, 3) returns 3, since 3^3 = 27.
        /// </summary>
        /// <param name="value">The BigInteger whose root is to be calculated.</param>
        /// <param name="num">The degree of the root.</param>
        /// <returns>The largest integer r such that r^n ≤ value; or -1 if bad input is provided.</returns>
        public static BigInteger IntegerRoot(BigInteger value, int num)
        {
            if (num == 1)
            {
                return value;
            }

            if (num < 1)
            {
                return -1;
            }

            if (value < 0)
            {
                return -1;
            }

            if (value == 0 || value == 1)
            {
                return value;
            }

            BigInteger low = 0;
            BigInteger high = value;

            while (low <= high)
            {
                BigInteger mid = (low + high) / 2;
                BigInteger midPow = BigInteger.Pow(mid, num);

                int comparer = midPow.CompareTo(value);

                if (comparer == 0)
                {
                    return mid;
                }
                else if (comparer < 0)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return high;
        }
    }
}

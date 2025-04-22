using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems.Problems
{
    /// <summary>
    /// Class relating to calculations involving divisors and multiples.
    /// </summary>
    public static class DivisorsAndMultiples
    {
        /// <summary>
        /// Finds the greatest common divisor of two numbers.
        /// </summary>
        /// <param name="a">First number.</param>
        /// <param name="b">Second number.</param>
        /// <returns>The greatest common divisor of a and b.</returns>
        public static long Gcd(long a, long b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (a != 0)
            {
                var temp = a;
                a = b % a;
                b = temp;
            }

            return b;
        }

        /// <summary>
        /// Finds the least common multiple of two numbers.
        /// </summary>
        /// <param name="a">First number.</param>
        /// <param name="b">Second number.</param>
        /// <returns>The lcm of the two nubers.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static long Lcm(long a, long b)
        {
            if (a == 0 || b == 0)
            {
                return 0;
            }

            return Math.Abs(a* b) / Gcd(a, b);
        }
    }
}

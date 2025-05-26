namespace ProjectEulerProblems.Problems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class for calculating digit powers of an integer.
    /// </summary>
    public static class DigitPowers
    {
        /// <summary>
        /// Gets the numbers such that its digits can be written as the sum of the powers.
        /// </summary>
        /// <param name="num">The exponent.</param>
        /// <returns>A list of numbers whose digits be written as a sum of the exponent.</returns>
        public static List<int> GetDigitPowers(int num)
        {
            var result = new List<int>();

            int max = (int)Math.Pow(9, num) * num;

            for (int i = 2; i < max; i++)
            {
                int sum = i.ToString().Sum(c => (int)Math.Pow(c - '0', num));
                if (sum == i)
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}

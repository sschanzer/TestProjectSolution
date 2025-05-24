namespace ProjectEulerProblems.Problems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class containing methods for evaluating cycles in a decemal expansion of a number.
    /// </summary>
    public static class ReciprocalCycles
    {
        /// <summary>
        /// Calculates the largest reciprocal cycle found in a decimal expansion up to the bound.
        /// </summary>
        /// <param name="bound">The bound inputted.</param>
        /// <returns>The denominator producting the largest cycle found in the decimal expansion of the numbers up to the bound.</returns>
        public static (int divisor, string cycle) GetLongestReciprocalCycle(int bound)
        {
            var maxLength = 0;
            int divisor = 0;
            string maxCycle = string.Empty;
            for (int i = 2; i < bound; i++)
            {
                string result = GetCycle(1, i);

                if (result.Length > maxLength)
                {
                    maxLength = result.Length;
                    divisor = i;
                    maxCycle = result;
                }
            }

            return (divisor, maxCycle);
        }

        /// <summary>
        /// Gets the cycle of the decimal expansion.
        /// </summary>
        /// <param name="numerator">The numerator.</param>
        /// <param name="denominator">The demoninator.</param>
        /// <returns>The cycle of the fractions decimal representation.</returns>
        private static string GetCycle(int numerator,  int denominator)
        {
            var remainder = numerator % denominator;
            Dictionary<int, int> remainderPositions = new Dictionary<int, int>();
            List<char> decimalDigits = new List<char>();

            int postion = 0;
            int repeatingStart = -1;

            while (remainder != 0)
            {
                if (remainderPositions.ContainsKey(remainder))
                {
                    repeatingStart = remainderPositions[remainder];
                    break;
                }

                remainderPositions[remainder] = postion;
                remainder *= 10;
                int digit = remainder / denominator;
                decimalDigits.Add((char)('0' + digit));
                remainder %= denominator;
                postion++;
            }

            string nonRepeating = repeatingStart == -1 ? new string(decimalDigits.ToArray()) : new string(decimalDigits.GetRange(0, repeatingStart).ToArray());

            string repeating = repeatingStart == -1 ? string.Empty : new string(decimalDigits.GetRange(repeatingStart, decimalDigits.Count - repeatingStart).ToArray());

            string decimalPart = nonRepeating + (repeating.Length > 0 ? $"{repeating}" : string.Empty);

            return decimalPart;
        }
    }
}

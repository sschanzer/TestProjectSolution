namespace ProjectEulerProblems.Problems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class containing methods reltated to integer cycles.
    /// </summary>
    public static class IntegerCycles
    {
        /// <summary>
        /// Finds the integer cycles of a number.
        /// </summary>
        /// <param name="num">The number inputted.</param>
        /// <returns>A list of integer cycles of the number inputted.</returns>
        public static List<int> GetIntegerCycles(int num)
        {
            var result = new List<int>();
            var numString = num.ToString();
            var digitLength = numString.Length;

            if (digitLength == 1 || numString.All(c => c.Equals(numString[0])))
            {
                result.Add(num);
                return result;
            }

            for (int i = 1; i <= digitLength; i++)
            {
                result.Add(int.Parse(numString));
                var tempFirst = numString[digitLength - 1];

                string newNumString = tempFirst.ToString() + numString.Remove(digitLength - 1);

                numString = newNumString;
            }

            return result;
        }

        /// <summary>
        /// Gets a list of the prime integer cycles up to the input.
        /// </summary>
        /// <param name="num">The bound we search for prime cycles up to.</param>
        /// <returns>A list of prime cycles.</returns>
        public static List<int> GetPrimeCycles(int num)
        {
            var result = new List<int>();

            for (int i = 1; i < num; i++)
            {
                if (i == 1)
                {
                    continue;
                }

                if (i == 2)
                {
                    result.Add(i);
                    continue;
                }

                if (i % 2 == 0)
                {
                    continue;
                }

                bool isPrimeCycle = true;

                var cycle = GetIntegerCycles(i);

                if (cycle.Any(x => x % 2 == 0))
                {
                    continue;
                }
                else
                {
                    foreach (var number in cycle)
                    {
                        if (!Primes.IsPrime(number))
                        {
                            isPrimeCycle = false;
                            break;
                        }
                    }
                }

                if (isPrimeCycle)
                {
                    result.Add(i);
                }
            }

            return result;
        }

        /// <summary>
        /// Counts the number of prime integer cycles up to the input.
        /// </summary>
        /// <param name="num">The bound we search for prime cycles up to.</param>
        /// <returns>The number of prime cycles up to the bound.</returns>
        public static int CountPrimeCycles(int num)
        {
            var count = 0;

            for (int i = 1; i < num; i++)
            {
                if (i == 1)
                {
                    continue;
                }

                if (i == 2)
                {
                    count++;
                    continue;
                }

                if (i % 2 == 0)
                {
                    continue;
                }

                bool isPrimeCycle = true;

                var cycle = GetIntegerCycles(i);

                if (cycle.Any(x => x % 2 == 0))
                {
                    continue;
                }
                else
                {
                    foreach (var number in cycle)
                    {
                        if (!Primes.IsPrime(number))
                        {
                            isPrimeCycle = false;
                            break;
                        }
                    }
                }

                if (isPrimeCycle)
                {
                    count++;
                }
            }

            return count;
        }

    }
}

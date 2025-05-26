namespace ProjectEulerProblems.Problems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class containing methods used for calculating properties of arbitrary sequences.
    /// </summary>
    public static class Sequence
    {
        /// <summary>
        /// Determines the distinct powers of a^b.
        /// </summary>
        /// <param name="baseBound">The bound on a in a^b.</param>
        /// <param name="expBound">The bound on b in a^b.</param>
        /// <returns>A list of distinct elements.</returns>
        public static int FindDistinctPowers(int baseBound, int expBound)
        {
            HashSet<BigInteger> sequence = new HashSet<BigInteger>();

            for (int i = 2; i <= baseBound; i++)
            {
                for (int j = 2; j <= expBound; j++)
                {
                    var element = BigInteger.Pow(i, j);
                    sequence.Add(element);
                }
            }

            return sequence.Count;
        }
    }
}

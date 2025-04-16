using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems.Problems
{
    /// <summary>
    /// Class containing methods relating to the Fibonacci sequence.
    /// </summary>
    public class Fibonacci
    {
        /// <summary>
        /// Compiles a list of Fibonacci numbers.
        /// </summary>
        /// <param name="count">Number of terms of the seqeunce.</param>
        /// <returns>A list of Fibonacci numbers.</returns>
        public List<BigInteger> GetFibonacciNumbers(int count)
        {
            if (count <= 0)
            {
                return new List<BigInteger>();
            }

            var fibList = new List<BigInteger>() { 0 };

            if (count == 1)
            {
                return fibList;
            }

            fibList.Add(1);

            while (fibList.Count < count)
            {
                var nextTerm = fibList[fibList.Count - 2] + fibList[fibList.Count - 1];
                fibList.Add(nextTerm);
            }

            return fibList;
        }
    }
}

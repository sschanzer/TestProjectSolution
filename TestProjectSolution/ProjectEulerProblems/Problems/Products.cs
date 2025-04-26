using ProjectEulerProblems.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems.Problems
{
    /// <summary>
    /// Class containing methods relating to the Products of Numbers.
    /// </summary>
    public static class Products
    {
        /// <summary>
        /// Find the largest product of a substring of a given length broken down step-by-step.
        /// </summary>
        /// <param name="lengthOfSubstring">Desired length.</param>
        /// <param name="number">Number to extract largest product from.</param>
        /// <returns>The max product of the substrings.</returns>
        public static long FindLargestSubstringProduct_BreakDown(int lengthOfSubstring, string number)
        {
            // Generates the starting indices for all possible substrings of length 'length' within 'bigNum'.
            var startingIndexes = Enumerable.Range(0, number.Length - lengthOfSubstring + 1);

            // Create all substrings of length 'length' starting from each index in 'startingIndexes'.
            var allSubstringsOfProvidedLength = startingIndexes.Select(x => number.Substring(x, lengthOfSubstring));

            // allSubstringsOfProvidedLength.Select(sub => sub.Select(x => x - '0')) converts each substring into an integer array of size = 'length' which we cast to a long to avoid overflow.
            // The linq statement .Select(sub => sub.Select(x => x - '0')) subtracts the ASCII value of '0' (which is 48) from the ASCII value of the digit x, which directly gives us the integer value.
            // we then aggregate it and get the product of the array entries.
            var allProducts = allSubstringsOfProvidedLength.Select(sub => sub.Select(x => (long)(x - '0')).Aggregate(1L, (a, b) => a * b));

            // Takes the maximum of all the products we calculated.
            var maxProduct = allProducts.Max();

            return maxProduct;
        }

        /// <summary>
        /// Find the largest product of a substring of a given length broken down step-by-step.
        /// </summary>
        /// <param name="lengthOfSubstring">Desired length.</param>
        /// <param name="number">Number to extract largest product from.</param>
        /// <returns>The max product of the substrings.</returns>
        public static long FindLargestSubstringProduct(int lengthOfSubstring, string number)
        {
            // We can combined the above steps into a single linq statement.
            var maxProduct = Enumerable.Range(0, number.Length - lengthOfSubstring + 1).Select(x => number.Substring(x, lengthOfSubstring)).Max(sub => sub.Select(y => (long)(y - '0')).Aggregate(1L, (a, b) => a * b));

            return maxProduct;
        }
    }
}

namespace ProjectEulerProblems.Problems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class containing methods related counting permutations strings and numbers.
    /// </summary>
    public static class Permutations
    {
        /// <summary>
        /// Finds the Lexicographical Permutations of a given string.
        /// </summary>
        /// <param name="digits">The string we want to permute.</param>
        /// <param name="permCount">Optional parameter specifying which element of the permutation to return.</param>
        /// <returns>Full list of the permutation if permCount is default, otherwise we return the permCount's permutation.</returns>
        public static List<string> GetLexicographicPermutations(string digits, int permCount = 0)
        {
            var permutations = new List<string>();
            string orderedString = string.Concat(digits.OrderBy(x => x));

            GetPermutations(orderedString, string.Empty, permutations);

            if (permCount != 0)
            {
                return new List<string> { permutations[permCount - 1] };
            }

            return permutations;
        }

        /// <summary>
        /// Calculates the permutation of a given string recursively.
        /// </summary>
        /// <param name="remaining">The elements left to permute.</param>
        /// <param name="current">The current element we add to the permutation.</param>
        /// <param name="results">List of permutations.</param>
        public static void GetPermutations(string remaining, string current, List<string> results)
        {
            if (remaining.Length == 0)
            {
                results.Add(current);
                return;
            }

            for (int i = 0; i < remaining.Length; i++)
            {
                string next = remaining.Substring(0, i) + remaining.Substring(i + 1);
                GetPermutations(next, current + remaining[i], results);
            }
        }

        /// <summary>
        /// Generates all permutations of the characters in the input string using Heap's Algorithm.
        /// </summary>
        /// <param name="input">The string to permute.</param>
        /// <param name="nthPermutation">Optional parameter specifying which element of the permutation to return.</param>
        /// <returns>A list of all unique permutations in lexigraphical order.</returns>
        public static List<string> PermutationsViaHeaps(string input, int nthPermutation = 0)
        {
            int length = input.Length;

            // Convert the input string into a mutable character array
            char[] characters = input.ToCharArray();

            // Each position in the following array counts how many times we've swapped for index i.
            int[] loopCounters = new int[length];

            // The result list will hold all generated permutations
            List<string> permutations = new List<string>();

            // Add the initial (unswapped) permutation
            permutations.Add(new string(characters));

            var currentIndex = 0;

            // Implementation of Heap's Algorithm
            while (currentIndex < length)
            {
                if (loopCounters[currentIndex] < currentIndex)
                {
                    // Determine the index to swap with based on whether currentIndex is even or odd
                    int swapIndex = (currentIndex % 2 == 0) ? 0 : loopCounters[currentIndex];

                    // Swap the characters at swapIndex and currentIndex
                    char temp = characters[swapIndex];
                    characters[swapIndex] = characters[currentIndex];
                    characters[currentIndex] = temp;

                    // Add the new permutation to the result list
                    permutations.Add(new string(characters));

                    // Update the loop counter for this index and reset the currentIndex to 0
                    loopCounters[currentIndex]++;
                    currentIndex = 0;
                }
                else
                {
                    // Reset the loop counter and move to the next index
                    loopCounters[currentIndex] = 0;
                    currentIndex++;
                }
            }

            var orderedPermutations = permutations.OrderBy(x => x).ToList();

            if (nthPermutation != 0)
            {
                var permutationAtN = new List<string> { orderedPermutations[nthPermutation - 1] };
                return permutationAtN;
            }

            return orderedPermutations;
        }

        /// <summary>
        /// Gets the Nth permutation of the given string.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <param name="number">The element of the permutation we want.</param>
        /// <returns>The Nth permutation of the input string.</returns>
        public static List<string> GetNthPermutation(string input, int number)
        {
            var result = PermutationsViaHeaps(input, number);
            return result;
        }
    }
}

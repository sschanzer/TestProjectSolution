namespace ProjectEulerProblems.Problems
{
    using ProjectEulerProblems.Utilities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class containing methods related to pandigital numbers
    /// </summary>
    public static class PandigitalNumbers
    {
        /// <summary>
        /// Finds the sum of all products whose multiplicand/multiplier/product identity can be written as a pandigital.
        /// </summary>
        /// <param name="n">What the product should be pandigital up to; i.e. 5, 9.</param>
        /// <returns>The sum of all product of products whose multiplicand/multiplier/product identity can be written as a pandigital.</returns>
        public static int PandigitalProduct(int n)
        {
            var digits = string.Join(string.Empty, Enumerable.Range(1, n));
            var products = new HashSet<int>();

            foreach (var perm in Permutations.PermutationsViaHeaps(digits))
            {
                for (int i = 1; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        int a = int.Parse(perm.Substring(0, i));
                        int b = int.Parse(perm.Substring(i, j - i));
                        int c = int.Parse(perm.Substring(j));

                        if (a * b == c)
                        {
                            products.Add(c);
                        }
                    }
                }
            }

            return products.Sum();
        }

    }
}

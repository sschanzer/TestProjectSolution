// <copyright file="Pythagorean.cs" company="MyTestProject">
// Copyright (c) MyTestProject. All rights reserved.
// </copyright>

namespace ProjectEulerProblems.Problems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class containing methods relating to the Pythagorean theorem.
    /// </summary>
    public static class Pythagorean
    {
        /// <summary>
        /// Determines if the given nubers form a Pythagorean triple.
        /// </summary>
        /// <param name="a">First number.</param>
        /// <param name="b">Second number.</param>
        /// <param name="c">Third number.</param>
        /// <returns>True if the three numbers are a Pythagorean triple; otherwise false.</returns>
        public static bool IsPythagoreanTriple(int a, int b, int c)
        {
            if (a == 0 || b == 0 || c == 0)
            {
                return false;
            }

            var sides = new[] { a, b, c }.OrderBy(x => x).ToArray();

            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }

        /// <summary>
        /// Generates a list of Pythagorean triples up to the specified bound.
        /// </summary>
        /// <param name="max">The given bound.</param>
        /// <returns>A list of Pythagorean triples.</returns>
        public static List<(int a, int b, int c)> GeneratePythagoreanTriples(int max)
        {
            var pythagoreanTriples = new List<(int a, int b, int c)>();

            for (int i = 3; i < max; i++)
            {
                for (int j = i + 1; j < max; j++)
                {
                    var c = Math.Pow(Math.Pow(i, 2) + Math.Pow(j, 2), 0.5);

                    if (c == (int)c && (int)c <= max)
                    {
                        pythagoreanTriples.Add((i, j, (int)c));
                    }
                }
            }

            return pythagoreanTriples;
        }

        /// <summary>
        /// Generates a list of Primitive Pythagorean triples up to the specified bound.
        /// </summary>
        /// <param name="max">The given bound.</param>
        /// <returns>A list of Pythagorean triples.</returns>
        public static List<(int a, int b, int c)> GeneratePrimitivePythagoreanTriples(int max)
        {
            var primitiveTriples = new List<(int a, int b, int c)>();

            for (int i = 3; i < max; i++)
            {
                for (int j = i + 1; j < max; j++)
                {
                    var c = Math.Pow(Math.Pow(i, 2) + Math.Pow(j, 2), 0.5);

                    if (c == (int)c && (int)c <= max)
                    {
                        if (DivisorsAndMultiples.Gcd(i, DivisorsAndMultiples.Gcd(j, (long)c)) == 1)
                        {
                            primitiveTriples.Add((i, j, (int)c));
                        }
                    }
                }
            }

            return primitiveTriples;
        }

        /// <summary>
        /// Given a sum, finds the corresponding Pythagorean triple and it's product.
        /// </summary>
        /// <param name="targetSum">The given sum.</param>
        /// <returns>The Pythagorean triple whose sum is the given target, and it's associated product or the zero vector if it does not exist.</returns>
        public static (int a, int b, int c, long product) GetTargetTripleProduct(int targetSum)
        {
            for (int i = 3; i < targetSum; i++)
            {
                for (int j = i + 1; j < targetSum; j++)
                {
                    var c = Math.Pow(Math.Pow(i, 2) + Math.Pow(j, 2), 0.5);

                    if (c == (int)c)
                    {
                        if (targetSum == i + j + (int)c)
                        {
                            return (i, j, (int)c, i * j * (int)c);
                        }
                    }
                }
            }

            return (0, 0, 0, 0);
        }
    }
}

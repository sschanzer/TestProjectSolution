// <copyright file="Primes.cs" company="MyTestProject">
// Copyright (c) MyTestProject. All rights reserved.
// </copyright>

namespace ProjectEulerProblems.Problems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using ProjectEulerProblems.Utilities;

    /// <summary>
    /// Class containing methods relating to Prime numbers.
    /// </summary>
    public static class Primes
    {
        /// <summary>
        /// Implementation of the Sieve of Eratosthenes.
        /// </summary>
        /// <param name="num">Represents the bound.</param>
        /// <returns>A list of primes up to num.</returns>
        public static List<int> PrimeSieve(int num)
        {
            var primes = new List<int>();

            // Less than zero returns an empty list.
            if (num < 0)
            {
                return primes;
            }

            var sieve = new bool[num];

            // Set everything int the bool array to true (so all are entries are considered prime)
            for (int i = 0; i < sieve.Length; i++)
            {
                sieve[i] = true;
            }

            // Set zero and one as not prime
            sieve[0] = sieve[1] = false;

            for (int i = 2; i < Math.Pow(num, 0.5);  i++)
            {
                if (sieve[i])
                {
                    // sieve[i] is prime, so mark all multiples of sieve[i] as not prime.
                    for (int j = i * i; j < num; j += i)
                    {
                        sieve[j] = false;
                    }
                }
            }

            // Now all indexes of the bool array with a value of true are prime
            for (int i = 2; i < num; i++)
            {
                if (sieve[i])
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        /// <summary>
        /// Brute force method of getting primes utilizing factors.
        /// </summary>
        /// <param name="num">Represents the bound.</param>
        /// <returns>A list of prime numbers up to num.</returns>
        public static List<int> GetPrimesBrute(int num)
        {
            var primes = new List<int>();

            for (int i = 2; i < num; i++)
            {
                var factors = Functions.GetFactors(i);

                if (factors.Count == 2)
                {
                    primes.Add(i);
                }

                factors.Clear();
            }

            return primes;
        }

        /// <summary>
        /// Method to determine if a given number is prime.
        /// </summary>
        /// <param name="num">The number.</param>
        /// <returns>True if the numer is prime, false otherwise.</returns>
        public static bool IsPrime(long num)
        {
            if (num < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Gets the largest prime factor of the number.
        /// </summary>
        /// <param name="num">The number in question.</param>
        /// <returns>The largest prime factor of the num.</returns>
        public static long GetLargestPrimeFactors(long num)
        {
            var factorList = Functions.GetFactors(num);

            for (int i = factorList.Count - 1; i > 0; i--)
            {
                var factorOfFactors = Functions.GetFactors(factorList[i]);

                if (factorOfFactors.Count == 2)
                {
                    return factorList[i];
                }
            }

            return -1;
        }

        /// <summary>
        /// Implementation of the Sieve of Eratosthenes.
        /// </summary>
        /// <param name="num">Represents the bound.</param>
        /// <returns>A list of primes having count equal to the bound.</returns>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/Rosser%27s_theorem.
        /// </remarks>
        public static List<int> PrimeSieveForNumberOfPrimes(int num)
        {
            var primes = new List<int>();

            // Less than zero returns an empty list.
            if (num < 0)
            {
                return primes;
            }

            // Estimate an upper bound for the nth Rosser's Theorem
            // For n >= 6, nth prime is < n * (ln(n) + ln(ln(n)))
            int estimatedBound = num < 6 ? 15 : (int)(num * (Math.Log(num) + Math.Log(Math.Log(num))));

            // Keep increasing bound until we find enough primes
            while (true)
            {
                primes = PrimeSieve(estimatedBound);

                if (primes.Count >= num)
                {
                    return primes.Take(num).ToList();
                }

                estimatedBound *= 2; // Increase bound and try again
            }
        }

        /// <summary>
        /// Approximates the number of primes less than the given number.
        /// </summary>
        /// <param name="num">The number given.</param>
        /// <returns>The approximate number of primes less than the number.</returns>
        public static double PrimeCountingFunction(long num)
        {
            return num / Math.Log(num);
        }

        /// <summary>
        /// Evaluates the sum of all primes up to the given bound.
        /// </summary>
        /// <param name="bound">The provided bound.</param>
        /// <returns>Sum of all primes up to the bound.</returns>
        public static BigInteger SumOfPrimes(int bound)
        {
            BigInteger primeSum = 0;

            if (bound < 2)
            {
                return primeSum;
            }

            var sieve = Enumerable.Repeat(true, bound + 1).ToArray();

            sieve[0] = sieve[1] = false;

            for (int i = 2; i * i <= bound; i++)
            {
                if (sieve[i])
                {
                    for (int j = i * i; j <= bound; j += i)
                    {
                        sieve[j] = false;
                    }
                }
            }

            for (int i = 2; i <= bound; i++)
            {
                if (sieve[i])
                {
                    primeSum += i;
                }
            }

            return primeSum;
        }

        /// <summary>
        /// Finds the product of coefficients in a quadradic expression which produces the maximal consecutive prime numbers.
        /// </summary>
        /// <param name="bound">Bound for the First order and constant coefficient terms of the quadradic.</param>
        /// <returns>The product of coefficients in the quadradic expression producing the maximal consecutive prime numbers.</returns>
        public static (int a, int b) ProductOfQuadradicCoefficientsProducingMaximalConsecutivePrimes(int bound)
        {
            var consecutivePrimesLength = 0;
            (int a, int b) coefficientTuple = (0, 0);
            for (int i = -bound + 1; i < bound; i++)
            {
                for (int j = 0; j <= bound; j++)
                {
                    if (IsPrime(j))
                    {
                        var consecutivePrimesOfQuadradic = ConsecutiveQuadradicPrimes(i, j);
                        var currentConsecutivePrimesLength = consecutivePrimesOfQuadradic.Count;
                        if (currentConsecutivePrimesLength > consecutivePrimesLength)
                        {
                            consecutivePrimesLength = currentConsecutivePrimesLength;
                            coefficientTuple = (i, j);
                        }
                    }
                }
            }

            return coefficientTuple;
        }

        /// <summary>
        /// Evaluates the consecutive primes the coefficients product for the quadradic n^2 + an + b.
        /// </summary>
        /// <param name="a">First order coefficient.</param>
        /// <param name="b">Constant coefficient.</param>
        /// <returns>A list of consecutive prime numbers the quadradic produces with the provided coefficients.</returns>
        private static List<int> ConsecutiveQuadradicPrimes(int a, int b)
        {
            List<int> consecutivePrimeList = new List<int>();

            for (int n = 0; n < 1000;  n++)
            {
                var currentQuadradicEvaluation = (n * n) + (a * n) + b;
                var isPrime = IsPrime(currentQuadradicEvaluation);
                if (isPrime)
                {
                    consecutivePrimeList.Add(currentQuadradicEvaluation);
                }
                else
                {
                    break;
                }
            }

            return consecutivePrimeList;
        }
    }
}

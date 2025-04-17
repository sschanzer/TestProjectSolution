using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems.Problems
{
    /// <summary>
    /// Class containing methods relating to Prime numbers.
    /// </summary>
    public class Primes
    {
        /// <summary>
        /// Implementation of the Sieve of Eratosthenes.
        /// </summary>
        /// <param name="num">Represents the bound.</param>
        /// <returns>A list of primes up to num.</returns>
        public List<int> PrimeSieve(int num)
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
    }
}

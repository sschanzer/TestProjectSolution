using System;
using System.Linq;

namespace ProjectEulerProblems.Problems
{
    /// <summary>
    /// Class containing methods relating to the Palindromic Numbers.
    /// </summary>
    public class PalindromicNumbers
    {
        /// <summary>
        /// Finds the largest palindrome made from the product of two numbers with the specified number of digits.
        /// </summary>
        /// <param name="digits">The number of digits for the multiplicands (e.g. 2 for 2-digit numbers).</param>
        /// <returns>The largest palindromic product as a long, or 0 if none is found.</returns>
        public long GetLargestPalindromeProduct(int digits)
        {
            var stringNum = string.Empty;
            var boundString = "1";
            for (int i = 0; i < digits; i++)
            {
                stringNum += "9";
                boundString += "0";
            }

            boundString = boundString.Remove(boundString.Length - 1);
            int bound = int.Parse(boundString);
            int startingNum = int.Parse(stringNum);

            for (int i = startingNum; i > 0; i--)
            {
                for (int j = startingNum; j > startingNum - bound; j--)
                {
                    long product = i * j;

                    if (this.IsPalindrome(product))
                    {
                        return product;
                    }
                }
            }

            return 0;
        }

        /// <summary>
        /// Method to check if a number is a palindrome.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>True if the number is a palindrome, false otherwise.</returns>
        public bool IsPalindrome(long number)
        {
            var numString = number.ToString();

            if (numString.Length % 2 == 0)
            {
                for (int i = 0; i < numString.Length; i++)
                {
                    if (numString[i] != numString[numString.Length - 1 - i])
                    {
                        return false;
                    }
                }

                return true;
            }

            var middleIndex = numString.Length / 2;

            for (int i = 0; i < numString.Length; i++)
            {
                if (numString[i] == numString[middleIndex])
                {
                    return true;
                }

                if (numString[i] != numString[numString.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}

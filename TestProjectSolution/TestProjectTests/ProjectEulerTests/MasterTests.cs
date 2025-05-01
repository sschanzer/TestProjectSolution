using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerProblems.Data;
using ProjectEulerProblems.Problems;
using ProjectEulerProblems.Utility;
using static System.Net.WebRequestMethods;

namespace TestProjectTests.ProjectEulerTests
{
	/// <summary>
	/// Test class for all of the Project Euler Problems.
	/// </summary>
	[TestClass]
	public class MasterTests
	{
        /// <summary>
        /// Project Euler Problem 1.
        /// Find the sum of all the multiples of 3 or 5 below 1000.
        /// <see href="https://projecteuler.net/problem=1">Problem 1 description</see>.
        /// </summary>
        [TestMethod]
		[TestCategory(TestList.ProjectEulerTests)]
        [DataRow(1000, 233168)]
        public void TestProjectEuler_Problem_One(int num, int answer)
		{
            var result = SumSequence.GetSumSlick(num);
            Assert.AreEqual(answer, result);
        }

        /// <summary>
        /// Project Euler Problem 2.
        /// Find the sum of the even-valued terms in the Fibonacci sequence whose values are less than four million.
        /// <see href="https://projecteuler.net/problem=2">Problem 2 description</see>.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(34,4613732)]
        public void TestProjectEuler_Problem_Two(int num, int answer)
        {
            var fibSum = Fibonacci.GetEvenFibSumRedux(num);

            Assert.AreEqual(answer, fibSum);
        }

        /// <summary>
        /// Project Euler Problem 3.
        /// What is the largest prime factor of the number 600851475143?
        /// <see href="https://projecteuler.net/problem=3">Problem 3 description</see>.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(600851475143, 6857)]
        public void TestProjectEuler_Problem_Three(long number, int answer)
        {
            var largestFactor = Primes.GetLargestPrimeFactors(number);

            Assert.AreEqual(answer, largestFactor);
        }

        /// <summary>
        /// Project Euler Problem 4.
        /// Find the largest palindrome made from the product of two 3-digit numbers.
        /// <see href="https://projecteuler.net/problem=4">Problem 4 description</see>.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(3, 906609)]
        public void TestProjectEuler_Problem_Four(int digits, long answer)
        {
            long result = PalindromicNumbers.GetLargestPalindromeProduct(digits);
            Assert.AreEqual(answer, result);
        }

        /// <summary>
        /// Project Euler Problem 5.
        /// What is the smallest positive number that is evenly divisible with no remainder by all of the numbers from 1 to 20.
        /// <see href="https://projecteuler.net/problem=5">Problem 5 description</see>.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }, 232792560)]

        public void TestProjectEuler_Problem_Five(int[] input, int answer)
        {
            var result = SmallestMultiple.FindSmallestMultiple(input.ToList());
            Assert.AreEqual(answer, result);
        }

        /// <summary>
        /// Project Euler Problem 6.
        /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        /// <see href="https://projecteuler.net/problem=6">Problem 6 description</see>.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(100, 25164150)]
        public void TestProjectEuler_Problem_Six(int num, int answer)
        {
            int sumOfNumbersUpToNum = SumSequence.SumOfMultiples(1, num);
            int sumOfSquares = SumSequence.SumOfSquares(num);

            var squareOfSum = Math.Pow(sumOfNumbersUpToNum, 2);

            var difference = squareOfSum - sumOfSquares;

            Assert.AreEqual(answer, difference);
        }

        /// <summary>
        /// Project Euler Problem 7.
        /// What is the 10001 st prime number?
        /// <see href="https://projecteuler.net/problem=7">Problem 7 description</see>.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(10001, 104743)]
        public void TestProjectEuler_Problem_Seven(int bound, int answer)
        {
            var primeList = Primes.PrimeSieveForNumberOfPrimes(bound);

            Assert.AreEqual(answer, primeList.Last());
        }

        /// <summary>
        /// <para>
        /// Project Euler Problem 8.
        /// Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product?
        /// <see href="https://projecteuler.net/problem=8">Problem 8 description</see>.
        /// </summary>
        /// <param name="length">The number of adjacent digits.</param>
        /// <param name="answer">The accepted answer for the problem.</param>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(13, 23514624000)]
        public void TestProjectEuler_Problem_Eight(int length, long answer)
        {
            var bigNum = ProblemEightData.ProblemEightNumber;
            var result = Products.FindLargestSubstringProduct(length, bigNum);

            Assert.AreEqual(answer, result);
        }

        /// <summary>
        /// Project Euler Problem 9.
        /// There exists exactly one Pythagorean triplet for which a + b + c = 1000. Find its product abc.
        /// <see href="https://projecteuler.net/problem=9">Problem 9 description</see>.
        /// </summary>
        /// <param name="targetSum">Target sum.</param>
        /// <param name="expectedA">Expected 'a' value.</param>
        /// <param name="expectedB">Expected 'b' value.</param>
        /// <param name="expectedC">Expected 'c' value.</param>
        /// <param name="answer">Expected product of the triple.</param>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(1000, 200, 375, 425, 31875000)]
        public void TestProjectEuler_Problem_Nine(int targetSum, int expectedA, int expectedB, int expectedC, long answer)
        {
            var (a, b, c, product) = Pythagorean.GetTargetTripleProduct(targetSum);

            Assert.AreEqual(expectedA, a, "a mismatch");
            Assert.AreEqual(expectedB, b, "b mismatch");
            Assert.AreEqual(expectedC, c, "c mismatch");
            Assert.AreEqual(answer, product, "product mismatch");
        }

        /// <summary>
        /// Project Euler Problem 10.
        /// Find the sum of all the primes below two million.
        /// <see href="https://projecteuler.net/problem=10">Problem 10 description</see>.
        /// </summary>
        /// <param name="bound">Where we want the sum to stop.</param>
        /// <param name="answerString">The expected output as a string since Data Rows don't how to convert an int to a BigInteger.</param>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(2000000, "142913828922")]
        public void TestProjectEuler_Problem_Ten(int bound, string answerString)
        {
            var answer = BigInteger.Parse(answerString);
            var mySum = Primes.SumOfPrimes(bound);

            Assert.AreEqual(answer, mySum);
        }

        /// <summary>
        /// Project Euler Problem 11.
        /// What is the greatest product of four adjacent numbers in the same direction(up, down, left, right, or diagonally) in the 20 * 20 grid?
        /// <see href="https://projecteuler.net/problem=11">Problem 11 description</see>.
        /// </summary>
        /// <param name="filePath">File path.</param>
        /// <param name="length">Requested length of the substring.</param>
        /// <param name="answer">The answer.</param>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DeploymentItem(@"ProjectEulerTests\TestData\ProjectEulerProblemEleven.txt")]
        [DataRow("ProjectEulerProblemEleven.txt", 4, 70600674)]
        public void TestProjectEuler_Problem_Eleven(string filePath, int length, int answer)
        {
            var maxProduct = Products.FindLargestProductOfGrid(filePath, length);
            Assert.AreEqual(answer, maxProduct);
        }

        /// <summary>
        /// Project Euler Problem 12.
        /// What is the value of the first triangle number to have over five hundred divisors?
        /// <see href="https://projecteuler.net/problem=12">Problem 12 description</see>.
        /// </summary>
        /// <param name="numberOfFactors">Number of factors required for the problem.</param>
        /// <param name="answer">Problem solution.</param>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(500, 76576500)]
        public void TestProjectEuler_Problem_Twelve(int numberOfFactors, int answer)
        {
            var result = TriangularNumbers.GetFirstTriangularNumberWithAtLeastNFactors(numberOfFactors);
            Assert.AreEqual(answer, result);
        }

        /// <summary>
        /// Project Euler Problem Thriteen.
        /// Work out the first ten digits of the sum of the one-hundred 50-digit numbers found in \TestData\ProjectEulerProblemThirteen.txt.
        /// <see href="https://projecteuler.net/problem=13">Problem 13 description</see>.
        /// </summary>
        /// <param name="filePath">File path.</param>
        /// <param name="answer">Problem solution.</param>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DeploymentItem(@"ProjectEulerTests\TestData\ProjectEulerProblemThirteen.txt")]
        [DataRow("ProjectEulerProblemThirteen.txt", 5537376230)]
        public void TestProjectEuler_Problem_Thirteen(string filePath, long answer)
        {
            var fileParser = new FileParser(filePath);
            var myNumArray = fileParser.ReadAllLines();
            
            BigInteger mySum = 0;

            foreach (string num in myNumArray)
            {
                mySum += BigInteger.Parse(num);
            }

            long result = long.Parse(mySum.ToString().Substring(0, 10));

            Assert.AreEqual(answer, result);
        }

        /// <summary>
        /// Project Euler Problem Fourteen.
        /// Which starting number, under one million, produces the longest Collatz chain.
        /// <see href="https://projecteuler.net/problem=14">Problem 14 description</see>.
        /// </summary>
        /// <param name="filePath">File path.</param>
        /// <param name="answer">Problem solution.</param>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(10000, 55373)]
        public void TestProjectEuler_Problem_Fourteen(int input, int answer)
        {
        }
    }
}

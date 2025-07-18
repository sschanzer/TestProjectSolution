// <copyright file="MasterTests.cs" company="MyTestProject">
// Copyright (c) MyTestProject. All rights reserved.
// </copyright>

namespace TestProjectTests.ProjectEulerTests
{
    using System;
    using System.Linq;
    using System.Numerics;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ProjectEulerProblems.Data;
    using ProjectEulerProblems.Problems;
    using ProjectEulerProblems.Utilities;
    using ProjectEulerProblems.Utility;

    /// <summary>
    /// Test class for all of the Project Euler Problems.
    /// </summary>
    [TestClass]
    public class MasterTests
    {
        /// <summary>
        /// Project Euler Problem 1.
        /// Find the sum of all the multiples of 3 or 5 below 1000.
        /// <see href="https://projecteuler.net/problem=1">Problem 1 description.</see>
        /// </summary>
        /// <param name="num">The number.</param>
        /// <param name="answer">The anwser.</param>
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
        /// <see href="https://projecteuler.net/problem=2">Problem 2 description.</see>
        /// </summary>
        /// <param name="num">The number.</param>
        /// <param name="answer">The anwser.</param>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(34, 4613732)]
        public void TestProjectEuler_Problem_Two(int num, int answer)
        {
            var fibSum = Fibonacci.GetEvenFibSumRedux(num);

            Assert.AreEqual(answer, fibSum);
        }

        /// <summary>
        /// Project Euler Problem 3.
        /// What is the largest prime factor of the number 600851475143?
        /// <see href="https://projecteuler.net/problem=3">Problem 3 description.</see>
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="answer">The anwser.</param>
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
        /// <see href="https://projecteuler.net/problem=4">Problem 4 description.</see>
        /// </summary>
        /// <param name="digits">The digits.</param>
        /// <param name="answer">The anwser.</param>
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
        /// <see href="https://projecteuler.net/problem=5">Problem 5 description.</see>
        /// </summary>
        /// <param name="input">The filePath.</param>
        /// <param name="answer">The anwser.</param>
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
        /// <see href="https://projecteuler.net/problem=6">Problem 6 description.</see>
        /// </summary>
        /// <param name="num">The number.</param>
        /// <param name="answer">The anwser.</param>
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
        /// <see href="https://projecteuler.net/problem=7">Problem 7 description.</see>
        /// </summary>
        /// <param name="bound">The bound.</param>
        /// <param name="answer">The anwser.</param>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(10001, 104743)]
        public void TestProjectEuler_Problem_Seven(int bound, int answer)
        {
            var primeList = Primes.PrimeSieveForNumberOfPrimes(bound);

            Assert.AreEqual(answer, primeList.Last());
        }

        /// <summary>
        /// Project Euler Problem 8.
        /// Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product?
        /// <see href="https://projecteuler.net/problem=8">Problem 8 description.</see>
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
        /// <see href="https://projecteuler.net/problem=9">Problem 9 description.</see>
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
        /// <see href="https://projecteuler.net/problem=10">Problem 10 description.</see>
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
        /// <see href="https://projecteuler.net/problem=11">Problem 11 description.</see>
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
        /// <see href="https://projecteuler.net/problem=12">Problem 12 description.</see>
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
        /// Project Euler Problem 13.
        /// Work out the first ten digits of the sum of the one-hundred 50-digit numbers found in \TestData\ProjectEulerProblemThirteen.txt.
        /// <see href="https://projecteuler.net/problem=13">Problem 13 description.</see>
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
        /// Project Euler Problem 14.
        /// Which starting number, under one million, produces the longest Collatz chain.
        /// <see href="https://projecteuler.net/problem=14">Problem 14 description.</see>
        /// </summary>
        /// <param name="bound">The given n to check the sequence up to.</param>
        /// <param name="answerKey">The expected key of the returned dictionary.</param>
        /// <param name="answerValue">The expected value of the returned dictionary.</param>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(1000000, 837799, 525)]
        public void TestProjectEuler_Problem_Fourteen(int bound, int answerKey, int answerValue)
        {
            var result = Collatz.FindLongesCollatzSequence(bound);
            var kvp = result.First();

            Assert.AreEqual(answerKey, kvp.Key);
            Assert.AreEqual(answerValue, kvp.Value);
        }

        /// <summary>
        /// Project Euler Problem 15.
        /// How many right/down routes are there through a 20 x 20 grid.
        /// <see href="https://projecteuler.net/problem=15">Problem 15 description.</see>
        /// </summary>
        /// <param name="n">The specified size of the n x n grid.</param>
        /// <param name="answer">The problem's solution.</param>
        /// <remarks>
        /// We can represent an n x n grid as an (n + 1) x (n + 1) graph having (n + 1) vertices.
        /// Given the restrictions in the problem, we find that any valid path in the problem will
        /// consist of n-right moves and n-down moves in some order, which is a total of 2n moves.
        /// The number of distinct paths is the same as the number of ways to choose n positions
        /// for the right/down moves out of a possible 2n ways; i.e. 2n choose n.
        /// </remarks>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(20, "137846528820")]
        public void TestProjectEuler_Problem_Fifteen(int n, string answer)
        {
            var result = BigIntegerExtensions.Choose(2 * n, n);
            Assert.AreEqual(BigInteger.Parse(answer), result);
        }

        /// <summary>
        /// Project Euler Problem 16.
        /// What is the sum of the digits of the number 2^{1000}?
        /// <see href="https://projecteuler.net/problem=16">Problem 16 description.</see>
        /// </summary>
        /// <param name="n">The base.</param>
        /// <param name="exp">The exponent.</param>
        /// <param name="answer">The answer.</param>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(2, 1000, 1366)]
        public void TestProjectEuler_Problem_Sixteen(int n, int exp, int answer)
        {
            var myExp = BigInteger.Pow(n, exp).ToString();
            var result = 0;

            foreach (char digit in myExp)
            {
                result += int.Parse(digit.ToString());
            }

            Assert.AreEqual(answer, result);
        }

        /// <summary>
        /// Project Euler Problem 17.
        /// If all the numbers from 1 to 1000 inclusive were written out in words, how many letters would be used?
        /// <see href="https://projecteuler.net/problem=17">Problem 17 description.</see>
        /// </summary>
        /// <param name="n">The filePath.</param>
        /// <param name="answer">The answer.</param>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(1000, 21124)]
        public void TestProjectEuler_Problem_Seventeen(int n, int answer)
        {
            var result = NumberLetterCounts.CountLettersOfNumbers(n);
            Assert.AreEqual(answer, result);
        }

        /// <summary>
        /// Project Euler Problem 18.
        /// Find the maximum total from top to bottom of the triangle shown.
        /// <see href="https://projecteuler.net/problem=18">Problem 18 description.</see>
        /// </summary>
        /// <param name="filePath">filePath.</param>
        /// <param name="answer">The answer.</param>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DeploymentItem(@"ProjectEulerTests\TestData\ProjectEulerProblemEighteen.txt")]
        [DataRow("ProjectEulerProblemEighteen.txt", 1074)]
        public void TestProjectEuler_Problem_Eighteen(string filePath, int answer)
        {
            var result = MaxPathSum.FindMaxPathSum_TopDown(filePath);
            Assert.AreEqual(answer, result);
        }

        /// <summary>
        /// Project Euler Problem 19.
        /// How many Sundays fell on the first of the month during the twentieth century?
        /// <see href="https://projecteuler.net/problem=19">Problem 19 description.</see>
        /// </summary>
        /// <param name="day">The day of the week we're interested in.</param>
        /// <param name="dayOfMonth">The day of the month we want our day to land on.</param>
        /// <param name="dateRange">The range dates we want to check.</param>
        /// <param name="answer">The accepted solution.</param>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow("Sunday", 1, "1 Jan 1901 to 31 Dec 2000", 171)]
        public void TestProjectEuler_Problem_Nineeen(string day, int dayOfMonth, string dateRange, int answer)
        {
            var result = CountingDays.CountNumberOfDays(day, dayOfMonth, dateRange);
            Assert.AreEqual(answer, result);
        }

        /// <summary>
        /// Project Euler Problem 20.
        /// Find the sum of the digits in the factorial 1000!.
        /// </summary>
        /// <see href="https://projecteuler.net/problem=20">Problem 20 description.</see>
        /// <param name="num">The number.</param>
        /// <param name="answer">The answer.</param>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(100, 648)]
        public void TestProjectEuler_Problem_Twenty(int num, int answer)
        {
            var result = Functions.GetFactorialDigitsSum(num);
            Assert.AreEqual(answer, result);
        }

        /// <summary>
        /// Project Euler Problem 21.
        /// Evaluate the sum of all amicable numbers under 10000.
        /// </summary>
        /// <see href="https://projecteuler.net/problem=21">Problem 21 description.</see>
        /// <param name="bound">The bound setting how many amicable values to go up to.</param>
        /// <param name="answer">The accepted solution on Project Euler.</param>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(10000, 31626)]
        public void TestProjectEuler_Problem_TwentyOne(int bound, int answer)
        {
            var result = AmicableNumbers.GetSumOfAmicableNumbers(bound);
            Assert.AreEqual(answer, result);
        }

        /// <summary>
        /// Project Euler Problem 22.
        /// What is the total of all the name scores in the file?
        /// <see href="https://projecteuler.net/problem=22">Problem 22 description.</see>
        /// </summary>
        /// <param name="filePath">File path to text file. </param>
        /// <param name="answer">The accepted solution on Project Euler.</param>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DeploymentItem(@"ProjectEulerTests\TestData\PEP22_Names.txt")]
        [DataRow("PEP22_Names.txt", 871198282)]
        public void TestProjectEuler_Problem_TwentyTwo(string filePath, int answer)
        {
            var result = NameScores.GetTotalOfAllNameScores(filePath);
            Assert.AreEqual(answer, result);
        }

        /// <summary>
        /// Project Euler Problem 23.
        /// Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.
        /// </summary>
        /// <see href="https://projecteuler.net/problem=23">Problem 23 description.</see>
        /// <param name="bound">The bound.</param>
        /// <param name="answer">The accepted solution on Project Euler.</param>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(28123, 4179871)]
        public void TestProjectEuler_Problem_TwentyThree(int bound, int answer)
        {
            var result = AbundantNumbers.GetAllNumbersNotASumOfTwoAbundantNumbers(bound);
            Assert.AreEqual(answer, result);
        }

        /// <summary>
        /// Project Euler Problem 24.
        /// Find the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9.
        /// </summary>
        /// <see href="https://projecteuler.net/problem=24">Problem 24 description.</see>
        /// <param name="input">The number as a string.</param>
        /// <param name="num">Element of permutation we want.</param>
        /// <param name="answer">The accepted solution on Project Euler.</param>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow("0123456789", 1000000, 2783915460)]
        public void TestProjectEuler_Problem_TwentyFour(string input, int num, long answer)
        {
            var permutation = Permutations.GetLexicographicPermutations(input, num);
            var result = long.Parse(permutation[0]);
            Assert.AreEqual(answer, result);
        }

        /// <summary>
        /// Project Euler Problem 25.
        /// Find the index of the first term in the Fibonacci sequence to contain 1000 digits.
        /// </summary>
        /// <see href="https://projecteuler.net/problem=25">Problem 25 description.</see>
        /// <param name="input">The number of digits we want the term to have.</param>
        /// <param name="answer">The accepted solution on Project Euler.</param>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(1000, "4782")]
        public void TestProjectEuler_Problem_TwentyFive(int input, string answer)
        {
            var result = Fibonacci.GetFirstFibsWithNDigits(1000);
            var answerInt = BigInteger.Parse(answer);
            Assert.AreEqual(answerInt, result);
        }

        /// <summary>
        /// Project Euler Problem 26.
        /// Find the value of d less than 1000 for which 1/d contains the longest recurring cycle in its decimal fraction part.
        /// </summary>
        /// <see href="https://projecteuler.net/problem=26">Problem 26 description.</see>
        /// <param name="input">The number of digits we want the term to have.</param>
        /// <param name="answer">The accepted solution on Project Euler.</param>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(1000, 983)]
        public void TestProjectEuler_Problem_TwentySix(int input, int answer)
        {
            var result = ReciprocalCycles.GetLongestReciprocalCycle(input);
            Assert.AreEqual(answer, result.divisor);
        }

        /// <summary>
        /// Project Euler Problem 27.
        /// Find the product of the coefficients, a and b, for the quadratic expression: n^2 + an + b that produces the maximum number of primes for consecutive values of n, starting with n = 0.
        /// </summary>
        /// <see href="https://projecteuler.net/problem=27">Problem 27 description.</see>
        /// <param name="bound">The bound for the coefficients.</param>
        /// <param name="answer">The accepted solution on Project Euler.</param>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(1000, -59231)]
        public void TestProjectEuler_Problem_TwentySeven(int bound, int answer)
        {
            var (a, b) = Primes.ProductOfQuadradicCoefficientsProducingMaximalConsecutivePrimes(bound);
            var product = a * b;
            Assert.AreEqual(answer, product);
        }

        /// <summary>
        /// Project Euler Problem 28.
        /// Find the sum of the numbers on the diagonals in a 1001 by 1001 spiral formed in the same way.
        /// </summary>
        /// <see href="https://projecteuler.net/problem=28">Problem 28 description.</see>
        /// <param name="bound">The bound for the coefficients.</param>
        /// <param name="answer">The accepted solution on Project Euler.</param>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(1001, 669171001)]
        public void TestProjectEuler_Problem_TwentyEight(int bound, int answer)
        {
            var result = SpiralGrid.GetDiagonalSumOfSpiralGrid(bound);
            Assert.AreEqual(answer, result);
        }

        /// <summary>
        /// Project Euler Problem 29.
        /// Find how many distinct terms are in the sequence generated by a^b for 2 <= a <= 100 and 2 <= b <= 100.
        /// </summary>
        /// <see href="https://projecteuler.net/problem=29">Problem 29 description.</see>
        /// <param name="bound">The bound for the base and exponent.</param>
        /// <param name="answer">The accepted solution on Project Euler.</param>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(100, 9183)]
        public void TestProjectEuler_Problem_TwentyNine(int bound, int answer)
        {
            var result = Sequence.FindDistinctPowers(bound, bound);
            Assert.AreEqual(answer, result);
        }

        /// <summary>
        /// Project Euler Problem 30.
        /// Find the sum of all the numbers that can be written as the sum of fifth powers of their digits.
        /// </summary>
        /// <see href="https://projecteuler.net/problem=30">Problem 30 description.</see>
        /// <param name="bound">The bound for the base and exponent.</param>
        /// <param name="answer">The accepted solution on Project Euler.</param>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(5, 443839)]
        public void TestProjectEuler_Problem_Thirty(int bound, int answer)
        {
            var result = DigitPowers.GetDigitPowers(bound);
            Assert.AreEqual(answer, result.Sum());
        }

        /// <summary>
        /// Project Euler Problem 31.
        /// Find how many different ways can £2 be made using any number of coins.
        /// </summary>
        /// <see href="https://projecteuler.net/problem=31">Problem 31 description.</see>
        /// <param name="coins">Denomination of coins as an integer array.</param>
        /// <param name="targetSum">The target sum.</param>
        /// <param name="answer">The accepted solution on Project Euler.</param>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(new int[] { 1, 2, 5, 10, 20, 50, 100, 200 }, 200, 73682)]
        public void TestProjectEuler_Problem_ThirtyOne(int[] coins, int targetSum, int answer)
        {
            var result = CoinSum.CountCoins(coins, targetSum);
            Assert.AreEqual(answer, result);
        }

        /// <summary>
        /// Project Euler Problem 32.
        /// Find the sum of all products whose multiplicand/multiplier/product identity can be written as a 1 through 9 pandigital.
        /// </summary>
        /// <see href="https://projecteuler.net/problem=32">Problem 32 description.</see>
        /// <param name="input">Number inputted.</param>
        /// <param name="answer">The accepted solution on Project Euler.</param>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(9, 45228)]
        public void TestProjectEuler_Problem_ThirtyTwo(int input, int answer)
        {
            var result = PandigitalNumbers.PandigitalProduct(input);
            Assert.AreEqual(answer, result);
        }

        /// <summary>
        /// Project Euler Problem 33
        /// If the product of these four fractions is given in its lowest common terms, find the value of the denominator.
        /// </summary>
        /// <see href="https://projecteuler.net/problem=33">Problem 33 description.</see>
        /// <param name="input">Number inputted.</param>
        /// <param name="answer">The accepted solution on Project Euler.</param>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(100, 100)]
        public void TestProjectEuler_Problem_ThirtyThree(int input, int answer)
        {
            var result = DigitCancellingFractions.GetProductOfDenominators(input);
            Assert.AreEqual(answer, result);
        }

        /// <summary>
        /// Project Euler Problem 34
        /// Find the sum of all numbers which are equal to the sum of the factorial of their digits.
        /// </summary>
        /// <see href="https://projecteuler.net/problem=34">Problem 34 description.</see>
        /// <param name="answer">The accepted solution on Project Euler.</param>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(40730)]
        public void TestProjectEuler_Problem_ThirtyFour(int answer)
        {
            var result = Functions.FindFactorions();
            Assert.AreEqual(answer, result.Sum());
        }

        /// <summary>
        /// Project Euler Problem 35
        /// Find How many circular primes are there below one million.
        /// </summary>
        /// <see href="https://projecteuler.net/problem=35">Problem 35 description.</see>
        /// <param name="input">Number inputted.</param>
        /// <param name="answer">The accepted solution on Project Euler.</param>
        [TestMethod]
        [TestCategory(TestList.ProjectEulerTests)]
        [DataRow(1000000, 55)]
        public void TestProjectEuler_Problem_ThirtyFive(int input, int answer)
        {
            var result = IntegerCycles.CountPrimeCycles(input);
            Assert.AreEqual(answer, result);
        }
    }
}

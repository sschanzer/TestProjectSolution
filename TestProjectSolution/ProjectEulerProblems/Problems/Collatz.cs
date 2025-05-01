using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectEulerProblems.Problems
{
    /// <summary>
    /// Class containing methods related to the Collatz conjecture.
    /// </summary>
    public static class Collatz
    {
        /// <summary>
        /// Finds the starting number that produces the longest Collatz Sequence up to the given bound.
        /// </summary>
        /// <param name="number">The bound we check up to.</param>
        /// <returns>Dictionary with Key = starting number that produces the longest Collatz Sequence under the provided number, and Value = the length of the sequence.</returns>
        public static Dictionary<int, int> FindLongesCollatzSequence(int number)
        {
            Dictionary<int, int> numLengthDict = new Dictionary<int, int>();
            int maxLength = 0;
            int largestNumber = 0;
            var cashedNumLengthDict = new Dictionary<long, List<long>>();

            if (number <= 0)
            {
                return numLengthDict;
            }

            if (number == 1 || number == 2)
            {
                numLengthDict.Add(number, 1);
                return numLengthDict;
            }

            for (int i = 2; i <= number; i++)
            {
                int length = 0;
                long tempNum = i;
                var sequence = new List<long>();

                while (tempNum != 1)
                {
                    sequence.Add(tempNum);

                    if (cashedNumLengthDict.Any(x => x.Value.Contains(tempNum)))
                    {
                        var elSeq = cashedNumLengthDict.First(x => x.Value.Contains(tempNum));

                        //var sequencInQuestion = cashedNumLengthDict[tempNum];

                        var kldjf = 1;

                        length += elSeq.Value.Count(); 
                        break;
                    }

                    if (tempNum % 2 == 0)
                    {
                        tempNum /= 2;
                    }
                    else
                    {
                        tempNum = (3 * tempNum) + 1;
                    }
                    length++;
                }

                cashedNumLengthDict[i] = sequence;

                if (length > maxLength)
                {
                    maxLength = length;
                    largestNumber = i;
                }
            }

            numLengthDict.Add(largestNumber, maxLength);

            return numLengthDict;
        }
    }
}

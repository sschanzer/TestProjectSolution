using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    /// <summary>
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that
    /// they add up to target. You may assume that each input would have exactly one solution, and you may
    /// not use the same element twice. You can return the answer in any order.
    /// </summary>
    /// <remarks>
    /// Input: nums = [2,7,11,15], target = 9
    /// Output: [0, 1]
    /// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
    /// </remarks>
    public class TwoSum
    {
        /// <summary>
        /// Brute force solution.
        /// </summary>
        /// <param name="nums">The input array.</param>
        /// <param name="target">The target int.</param>
        /// <returns>Integer array of the indicies of the two numbeers that sum to the target.</returns>
        public int[] TwoSum1(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    int sumOfNums = nums[i] + nums[j];

                    if (sumOfNums == target)
                    {
                        int[] solution = new int[] { i, j };

                        return solution;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Alternative solution.
        /// </summary>
        /// <param name="nums">The input array.</param>
        /// <param name="target">The target int.</param>
        /// <returns>Integer array of the indicies of the two numbeers that sum to the target.</returns>
        public int[] TwoSum2(int[] nums, int target)
        {
            /// Input: nums = [2,7,11,15], target = 9
            /// Output: [0, 1]
            /// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
            
            var indexMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var currentValue = nums[i];
                var difference = target - currentValue;

                if (indexMap.ContainsKey(difference))
                {
                    int idx = Array.IndexOf(nums, currentValue);
                    var solution = new int[] { indexMap[difference], idx };

                    return solution;
                }

                indexMap[currentValue] = i;

            }

            return null;
        }
    }
}

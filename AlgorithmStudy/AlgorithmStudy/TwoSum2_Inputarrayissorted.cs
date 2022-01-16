/*
 * Algorithm Day 4
 * Merge Two Sorted Lists
 * https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
 * 
 * 98.07% of C# but I saw its solution at last day ;D
 */

namespace AlgorithmStudy
{
    class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int[] targetIndex = new int[2];
            int minCursor = 0;
            int maxCursor = numbers.Length - 1;
            int sum;

            while (minCursor < maxCursor)
            {
                sum = numbers[minCursor] + numbers[maxCursor];
                if (sum == target)
                {
                    targetIndex[0] = minCursor + 1;
                    targetIndex[1] = maxCursor + 1;

                    break;
                }

                else if (sum > target)
                {
                    maxCursor--;
                }

                else
                {
                    minCursor++;
                }
            }
            return targetIndex;
        }
    }
}

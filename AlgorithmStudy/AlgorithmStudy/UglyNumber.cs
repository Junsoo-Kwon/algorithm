/*
 * Algorithm Day 3
 * UglyNumber
 * https://leetcode.com/problems/ugly-number/
 * 
 * 44 ms, faster than 44.22% of C#
 */

namespace UglyNumber
{
    class Solution
    {
        public bool IsUgly(int n)
        {
            if (n == 0)
            {
                return false;
            }

            while (n % 2 == 0)
            {
                n = n / 2;
            }

            while (n % 3 == 0)
            {
                n = n / 3;
            }

            while (n % 5 == 0)
            {
                n = n / 5;
            }

            if (n == 1)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}

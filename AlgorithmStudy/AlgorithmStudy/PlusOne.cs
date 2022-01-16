//20210719
//https://leetcode.com/problems/plus-one/

namespace PlusOne
{
    class Solution
    {
        public int[] PlusOne(int[] digits)
        {

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                digits[i]++;

                if (digits[0] == 10)
                {
                    int[] newDigits = new int[digits.Length + 1];
                    newDigits[0] = 1;
                    return newDigits;
                }

                else if (digits[i] == 10)
                {
                    digits[i] = 0;
                }

                else
                {
                    break;
                }
            }

            return digits;
        }
    }
}

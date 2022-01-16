// 20210706
// 1528. Shuffle String
// https://leetcode.com/problems/shuffle-string/ 

// 100 ms, faster than 97.01% of C#

namespace ShuffleString
{
    class Solution
    {
        public string RestoreString(string s, int[] indices)
        {
            char[] stringToChar = s.ToCharArray();
            char[] answerChar = new char[stringToChar.Length];

            for (int i = 0; i < stringToChar.Length; i++)
            {
                answerChar[indices[i]] = stringToChar[i];
            }
            
            return new string(answerChar);
        }
    }
}

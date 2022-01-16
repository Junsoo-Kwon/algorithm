/*
 * Algorithm Day 7
 * Implement strStr()
 * https://leetcode.com/problems/implement-strstr/
 * 
 * 84 ms, faster than 39.85% of C#
 */

namespace Implementstrstr
{
    class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            if(needle == "")
            {
                return 0;
            }

            char[] haystackChar = haystack.ToCharArray();
            char[] needleChar = needle.ToCharArray();
            
            for (int i = 0; i < haystackChar.Length; i++)
            {
                //실제 비교 연산을 위한 k
                int k = i;
                for (int j = 0; j <= needleChar.Length; j++)
                {
                    //needleChar를 끝까지 다 순회했을 경우 = 모든 글자가 일치 했을 경우
                    if(j == needleChar.Length)
                    {
                        return i;
                    }

                    //needle 글자수가 haystack 남은 글자수보다 많을 경우 일치하지 않음
                    if(k >= haystackChar.Length)
                    {
                        return -1;
                    }

                    //haystack 다음 글자 비교
                    if(haystackChar[k] == needleChar[j])
                    {
                        k++;
                    }

                    else
                    {
                        break;
                    }
                }
            }

            return -1;
        }

    }
}


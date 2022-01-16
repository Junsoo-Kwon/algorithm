/*
 * Algorithm Day 1
 * Palindrome Number (대칭 숫자)
 * https://leetcode.com/problems/palindrome-number/
 * 
 * 72.45% 속도
 */

using System;

namespace PalindromeNumber
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            char[] intToCharArray = (x.ToString()).ToCharArray();
            //입력받은 정수를 문자열로, 그리고 캐릭터 배열로

            int arrayPointer = 0;
            //배열 포인터 설정

            while (arrayPointer < intToCharArray.Length - (arrayPointer + 1))
            //양 포인터가 만날 때 반복문 종료
            {
                if (intToCharArray[arrayPointer] != intToCharArray[intToCharArray.Length - (arrayPointer + 1)])
                    //양 포인터 값들을 비교해서 다를 경우 거짓 반환
                {
                    return false;
                }
                arrayPointer++;
                //포인터 이동
            }

            return true;
        }
    }
}
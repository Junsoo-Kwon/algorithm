/*
 * Algorithm Day 1-2
 * Reverse Integer (정수 뒤집기)
 * https://leetcode.com/problems/reverse-integer/
 * 
 * 84% Faster than any C# user in Runtime
 */
using System;
using System.Collections.Generic;

namespace ReverseInteger
{
    public class Solution
    {
        public int Reverse(int x)
        {
            //리스트에 각 값들 저장
            List<int> getInteger = new List<int>();

            int pointerValue = 0; //쪼갠 후의 리스트에 넣을 값
            int chopedValue = x; //쪼개는 작업을 진행하는 값

            for (int i = 0; ; i++)
            {
                //더 이상 넣을 값이 없을 경우 반복문 종료
                if (chopedValue == 0)
                {
                    break;
                }

                pointerValue = chopedValue % 10;
                chopedValue = chopedValue / 10;

                getInteger.Add(pointerValue);
            } 

            int reverseValue = 0;
            for (int i = 0; i < getInteger.Count; i++)
            {
                //이하 오버플로우 및 언더플로우 확인
                if(reverseValue > Int32.MaxValue / 10
                    || (reverseValue == Int32.MaxValue / 10 && getInteger[i] > 7))
                {
                    return 0;
                }

                else if(reverseValue < Int32.MinValue / 10
                    || (reverseValue == Int32.MinValue / 10 && getInteger[i] < -8))
                {
                    return 0;
                }

                //예외사항이 발생하지 않았다면 숫자 다시 조립
                reverseValue = (reverseValue * 10) + getInteger[i];
            }

            return reverseValue;
        }
    }
}

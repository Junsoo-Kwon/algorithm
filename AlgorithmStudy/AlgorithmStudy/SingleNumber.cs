//Algorithm Day 8
//SingleNumber
//https://leetcode.com/problems/single-number/

//List 부분을 Hash 사용하면 빠르게 구현 가능
//784 ms, faster than 5.13% of C#


using System.Collections.Generic;

namespace SingleNumber
{
    class Solution
    {
        public int SingleNumber(int[] nums)
        {
            List<int> keyList = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j <= keyList.Count; j++)
                {
                    //리스트의 끝까지 순회를 했다면 해당 값 추가
                    if (j == keyList.Count)
                    {
                        keyList.Add(nums[i]);
                        break;
                    }

                    //도중 발견했다면 해당 값 제거
                    else if (nums[i] == keyList[j])
                    {
                        keyList.Remove(nums[i]);
                        break;
                    }
                }
            }

            //살아남은 값이 유일한 값
            return keyList[0];
        }
    }
}

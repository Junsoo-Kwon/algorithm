//Algorithm Day 9
//349. Intersection of Two Arrays
//https://leetcode.com/problems/intersection-of-two-arrays/

//224 ms, faster than 99.67% of C#

using System.Collections.Generic;

namespace IntersectionOfTwoArrays
{
    public class Solution
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> interValue = new HashSet<int>();
            List<int> interList = new List<int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                //Hash를 순회하면서 해당 값이 있는지 확인하고, 없다면 추가
                if (!interValue.Contains(nums1[i]))
                {
                    interValue.Add(nums1[i]);
                }
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                //Hash를 순회하면서 해당 값이 있고 리스트에 해당 값이 없다면 리스트에 추가
                if(interValue.Contains(nums2[i]) && !interList.Contains(nums2[i]))
                {
                    interList.Add(nums2[i]);
                }
            }

            int[] interArray = new int[interList.Count];
            interList.CopyTo(interArray);

            return interArray;
        }
    }
}

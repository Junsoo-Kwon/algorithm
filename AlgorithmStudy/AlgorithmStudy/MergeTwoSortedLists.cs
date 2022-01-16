/*
 * Algorithm Day 2
 * Merge Two Sorted Lists
 * https://leetcode.com/problems/merge-two-sorted-lists/
 * 
 * 96 ms, faster than 50.41% of C#
 */
using System;

namespace MergeTwoSortedLists
{
    public class ListNode
    {
        //주어진 연결 리스트 정의
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    
    class Solution
    {
        ListNode l3;
        //섞은 새로운 연결 리스트
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            #region 시작부터 null 인 경우 검출
            if (l1 == null && l2 != null)
            {
                return l2;
            }

            else if(l1 != null && l2 == null)
            {
                return l1;
            }

            else if(l1 == null && l2 == null)
            {
                return null;
            }
            #endregion

            while (!(l1==null && l2==null))
            {
                #region 연결 리스트에서 꺼내 쓰다 다 꺼낸 경우
                if (l2 == null)
                {
                    AddListNode(new ListNode(l1.val));
                    l1 = l1.next;
                }

                else if (l1 == null)
                {
                    AddListNode(new ListNode(l2.val));
                    l2 = l2.next;
                }
                #endregion

                #region 두 값 비교해서 작은 값 넣기
                else if (l1.val < l2.val)
                {
                    AddListNode(new ListNode(l1.val));
                    l1 = l1.next;
                }

                else if (l1.val >= l2.val)
                {
                    AddListNode(new ListNode(l2.val));
                    l2 = l2.next;
                }
                #endregion
            }
            return l3;
        }

        public void AddListNode(ListNode node)
        {
            if (l3 == null)
            {
                l3 = node;
            }

            else
            {
                //마지막 노드까지 이동
                ListNode temp = l3;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
    }
}

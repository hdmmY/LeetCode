using System;
using System.Collections.Generic;

namespace Leetcode23
{
    class Program
    {
        static void Main(string[] args)
        {
            var solu = new Solution();

            solu.MergeKLists(new ListNode[]
                {
                    new ListNode(0)
                });
        }
    }

    //Definition for singly-linked list.
    public class ListNode 
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    
    public class Solution 
    {
        public ListNode MergeKLists(ListNode[] lists) 
        {
            ListNode dummy = new ListNode(0);
            ListNode head = dummy;

            int[] vals = new int[lists.Length];
            
            // Initialize vals
            for(int i = 0; i < lists.Length; i++)
            {
                vals[i] = lists[i] == null ? Int32.MaxValue : lists[i].val; 
            }

            while(true)
            {
                int minIndex = FindMin(vals);
                
                if(minIndex == -1)  break;
                
                dummy.next = lists[minIndex];
                lists[minIndex] = lists[minIndex].next;
                dummy = dummy.next;

                vals[minIndex] = lists[minIndex] == null ? Int32.MaxValue : lists[minIndex].val;
            }

            return head.next;
        }

        public int FindMin(int[] vals)
        {
            int minValue = Int32.MaxValue;
            int minIndex = -1;

            for(int i = 0; i < vals.Length; i++)
            {
                if(vals[i] < minValue)
                {
                    minValue = vals[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }
    }
}

using System;

namespace Leetcode21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    // Definition for singly-linked list.
    public class ListNode 
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2) 
        {
            if(l1 == null)  return l2;
            if(l2 == null)  return l1;

            ListNode dummy = new ListNode(-1);
            ListNode head = null;

            if(l1.val < l2.val)
            {
                head = l1;
                l1 = l1.next;
            }
            else
            {
                head = l2;
                l2 = l2.next;
            }
            dummy.next = head;


            while(l1 != null && l2 != null)
            {
                if(l1.val < l2.val)
                {
                    head.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    head.next = l2;
                    l2 = l2.next;
                }
                
                head = head.next;
            }

            if(l1 == null)
            {
                head.next = l2;
            }
            else
            {
                head.next = l1;
            }

            return dummy.next;
        }
    }
}

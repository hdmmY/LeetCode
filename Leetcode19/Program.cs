using System;

namespace Leetcode19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
        public ListNode RemoveNthFromEnd(ListNode head, int n) 
        {
            ListNode emptyHead = new ListNode(-1);
            emptyHead.next = head;

            ListNode first = emptyHead;
            ListNode second = emptyHead;

            for(int i = 0; i <= n; i++)
            {
                first = first.next;
            }     

            while(first != null)
            {
                first = first.next;
                second = second.next;
            }

            second.next = second.next.next;

            return emptyHead.next;
        }
    }
}

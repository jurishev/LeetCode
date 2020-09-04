using System.Collections.Generic;

namespace Tiq.Easy.LinkedLists
{
    public class ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head is null)
            {
                return head;
            }

            var dic = new Dictionary<int, ListNode>();
            var i = 0;
            var node = head;

            while (node != null)
            {
                dic[++i] = node;
                node = node.next;
            }

            head = dic[i];
            node = head;

            while (--i > 0)
            {
                node.next = dic[i];
                node = node.next;
            }

            node.next = null;
            return head;
        }

        public ListNode ReverseListOnePass(ListNode head)
        {
            ListNode prev = null;

            while (head != null)
            {
                var next = head.next;
                head.next = prev;
                prev = head;
                head = next;
            }

            return prev;
        }
    }
}

using System.Collections.Generic;

namespace Tiq.Easy.LinkedLists
{
    public class RemoveFromEnd
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var dic = new Dictionary<int, ListNode>();
            var node = head;
            var i = 0;

            while (node != null)
            {
                dic[++i] = node;
                node = node.next;
            }

            if (i < 2)
            {
                return null;
            }

            if (i == n)
            {
                return head.next;
            }

            dic[i - n].next = dic[i - n + 1].next;
            return head;
        }
    }
}

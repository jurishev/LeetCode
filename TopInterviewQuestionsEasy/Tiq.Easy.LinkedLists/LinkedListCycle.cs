using System.Collections.Generic;

namespace Tiq.Easy.LinkedLists
{
    public class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            var hash = new HashSet<ListNode>();

            while (head != null)
            {
                if (hash.Contains(head))
                {
                    return true;
                }

                hash.Add(head);
                head = head.next;
            }

            return false;
        }
    }
}

namespace Tiq.Easy.LinkedLists
{
    public class MergeSortedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2) =>
            l1 is null ? l2 : l2 is null ? l1 : Merge(l1, l2);

        private ListNode Merge(ListNode l1, ListNode l2)
        {
            ListNode head = BiteNode(ref l1, ref l2);
            var current = head;

            while (l1 != null && l2 != null)
            {
                current.next = BiteNode(ref l1, ref l2);
                current = current.next;
            }

            current.next = l1 is null ? l2 : l1;
            return head;
        }

        private ListNode BiteNode(ref ListNode l1, ref ListNode l2)
        {
            ListNode node;

            if (l1.val < l2.val)
            {
                node = l1;
                l1 = l1.next;
            }
            else
            {
                node = l2;
                l2 = l2.next;
            }

            return node;
        }
    }
}

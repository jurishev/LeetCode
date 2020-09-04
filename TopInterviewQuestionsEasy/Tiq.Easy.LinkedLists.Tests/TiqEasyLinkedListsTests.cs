using Xunit;

namespace Tiq.Easy.LinkedLists.Tests
{
    public class TiqEasyLinkedListsTests
    {
        [Theory]
        [InlineData(new int[] { 0, 1 }, 0, new int[] { 1 })]
        [InlineData(new int[] { 4, 5, 1, 9 }, 5, new int[] { 4, 1, 9 })]
        [InlineData(new int[] { 1, 2, 3, 4 }, 3, new int[] { 1, 2, 4 })]
        [InlineData(new int[] { -3, 5, -99 }, -3, new int[] { 5, -99 })]
        public void DeleteNodeTest(int[] values, int n, int[] expected)
        {
            var head = InitializeLinkedList(values);
            var node = head;

            while (node.val != n)
            {
                node = node.next;
            }

            new DeleteNodeSolution().DeleteNode(node);

            AssertLinkedList(head, expected);
        }

        [Theory]
        [InlineData(new int[] { 1 }, 1, new int[] { })]
        [InlineData(new int[] { 1, 2 }, 1, new int[] { 1 })]
        [InlineData(new int[] { 1, 2 }, 2, new int[] { 2 })]
        [InlineData(new int[] { 1, 2, 3 }, 3, new int[] { 2, 3 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 1, 2, 3, 5 })]
        public void RemoveNthFromEndTest(int[] values, int n, int[] expected)
        {
            var head = InitializeLinkedList(values);
            head = new RemoveFromEnd().RemoveNthFromEnd(head, n);

            AssertLinkedList(head, expected);
        }

        [Theory]
        [InlineData(new int[] { 1 }, new int[] { 1 })]
        [InlineData(new int[] { 1, 2 }, new int[] { 2, 1 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
        public void ReverseListTest(int[] values, int[] expected)
        {
            var head = InitializeLinkedList(values);
            head = new ReverseLinkedList().ReverseListOnePass(head);

            AssertLinkedList(head, expected);
        }

        [Theory]
        [InlineData(new int[] { },new int[] { },new int[] { })]
        [InlineData(new int[] { }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { 3 }, new int[] { 1, 2 }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { 2, 3 }, new int[] { 1, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 2, 4 }, new int[] { 1, 3, 4 }, new int[] { 1, 1, 2, 3, 4, 4 })]
        public void MergeTwoListsTest(int[] l1, int[] l2, int[] expected)
        {
            var head1 = InitializeLinkedList(l1);
            var head2 = InitializeLinkedList(l2);

            var merged = new MergeSortedLists().MergeTwoLists(head1, head2);

            AssertLinkedList(merged, expected);
        }

        private void AssertLinkedList(ListNode head, int[] expected)
        {
            foreach (var val in expected)
            {
                Assert.Equal(val, head.val);
                head = head.next;
            }
        }

        private ListNode InitializeLinkedList(int[] values)
        {
            if (values.Length == 0)
            {
                return null;
            }

            var i = 0;
            var head = new ListNode(values[i]);
            var node = head;

            while (++i < values.Length)
            {
                node.next = new ListNode(values[i]);
                node = node.next;
            }

            return head;
        }
    }
}

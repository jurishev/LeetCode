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

            node = head;

            foreach (var val in expected)
            {
                Assert.Equal(val, node.val);
                node = node.next;
            }
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

            foreach (var val in expected)
            {
                Assert.Equal(val, head.val);
                head = head.next;
            }
        }

        private ListNode InitializeLinkedList(int[] values)
        {
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

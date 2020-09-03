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
        public void DeleteNodeTestATrue(int[] values, int n, int[] expected)
        {
            var head = InitializeDeleteNodeList(values);
            var node = head;

            while (node.val != n)
            {
                node = node.next;
            }

            new DeleteNode.DeleteNodeSolution().DeleteNode(node);

            node = head;

            foreach (var val in expected)
            {
                Assert.Equal(val, node.val);
                node = node.next;
            }
        }

        private DeleteNode.ListNode InitializeDeleteNodeList(int[] values)
        {
            var i = 0;
            var head = new DeleteNode.ListNode(values[i]);
            var node = head;

            while (++i < values.Length)
            {
                node.next = new DeleteNode.ListNode(values[i]);
                node = node.next;
            }

            return head;
        }
    }
}

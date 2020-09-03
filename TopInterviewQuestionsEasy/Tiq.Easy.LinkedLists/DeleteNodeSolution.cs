namespace Tiq.Easy.LinkedLists
{
    public class DeleteNodeSolution
    {
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}

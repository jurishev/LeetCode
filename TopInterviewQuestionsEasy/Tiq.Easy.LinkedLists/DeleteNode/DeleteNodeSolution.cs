namespace Tiq.Easy.LinkedLists.DeleteNode
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

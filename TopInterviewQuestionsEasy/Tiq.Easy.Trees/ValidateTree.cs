namespace Tiq.Easy.Trees
{
    public class ValidateTree
    {
        public bool IsValidBST(TreeNode root) => IsValid(root, null, null);

        private bool IsValid(TreeNode node, TreeNode rightParent, TreeNode leftParent)
        {
            if (node is null)
            {
                return true;
            }

            var lowerThanRightParent = rightParent is null || node.val < rightParent.val;
            var greaterThanLeftParent = leftParent is null || node.val > leftParent.val;

            var validSubTrees = 
                IsValid(node.left, node, leftParent) && IsValid(node.right, rightParent, node);

            return lowerThanRightParent && greaterThanLeftParent && validSubTrees;
        }
    }
}

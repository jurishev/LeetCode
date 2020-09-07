using System.Collections.Generic;

namespace Tiq.Easy.Trees
{
    public class LevelOrderSolution
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root is null)
            {
                return new List<IList<int>>();
            }

            var queue = new Queue<TreeNode>();

            var values = new Dictionary<int, List<int>>()
            {
                [1] = new List<int>() { root.val }
            };

            var levels = new Dictionary<TreeNode, int>()
            {
                [root] = 1
            };

            while (root != null)
            {
                var currentLevel = levels[root];
                var nextLevel = currentLevel + 1;

                if (root.left !=null || root.right != null)
                {
                    if (!values.ContainsKey(nextLevel))
                    {
                        values[nextLevel] = new List<int>();
                    }
                }

                if (root.left != null)
                {
                    queue.Enqueue(root.left);
                    levels[root.left] = nextLevel;
                    values[nextLevel].Add(root.left.val);
                }

                if (root.right != null)
                {
                    queue.Enqueue(root.right);
                    levels[root.right] = nextLevel;
                    values[nextLevel].Add(root.right.val);
                }

                root = queue.Count > 0 ? queue.Dequeue() : null;
            }

            return new List<IList<int>>(values.Values);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Tiq.Easy.Trees
{
    public class SymmetricTree
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root is null)
            {
                return true;
            }

            var queue = new Queue<TreeNode>();
            var values = new Dictionary<int, List<int?>>();
            var levels = new Dictionary<TreeNode, int>()
            {
                [root] = 1
            };

            while (root != null)
            {
                var currentLevel = levels[root];
                var nextLevel = currentLevel + 1;

                if (!values.ContainsKey(nextLevel))
                {
                    values[nextLevel] = new List<int?>();
                }

                if (root.left != null)
                {
                    queue.Enqueue(root.left);
                    levels[root.left] = nextLevel;
                    values[nextLevel].Add(root.left.val);
                }
                else
                {
                    values[nextLevel].Add(null);
                }

                if (root.right != null)
                {
                    queue.Enqueue(root.right);
                    levels[root.right] = nextLevel;
                    values[nextLevel].Add(root.right.val);
                }
                else
                {
                    values[nextLevel].Add(null);
                }

                root = queue.Count > 0 ? queue.Dequeue() : null;
            }

            foreach (var list in values.Values)
            {
                if (!list.SequenceEqual(list.Reverse<int?>()))
                {
                    return false;
                }
            }

            return true;
        }
    }
}

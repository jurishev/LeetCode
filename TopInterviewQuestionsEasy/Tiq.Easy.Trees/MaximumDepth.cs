using System;
using System.Collections.Generic;
using System.Linq;

namespace Tiq.Easy.Trees
{
    public class MaximumDepth
    {
        public int MaxDepth(TreeNode root)
        {
            if (root is null)
            {
                return 0;
            }

            var dic = new Dictionary<TreeNode, int>()
            {
                [root] = 1
            };

            var queue = new Queue<TreeNode>();

            while (root != null)
            {
                var depth = dic[root];

                if (root.left != null)
                {
                    queue.Enqueue(root.left);
                    dic[root.left] = depth + 1;
                }

                if (root.right != null)
                {
                    queue.Enqueue(root.right);
                    dic[root.right] = depth + 1;
                }

                root = queue.Count > 0 ? queue.Dequeue() : null;
            }

            return dic.Values.Max();
        }

        public int MaxDepthRecursive(TreeNode root) => root is null ? 0 :
            1 + Math.Max(MaxDepthRecursive(root.left), MaxDepthRecursive(root.right));
    }
}

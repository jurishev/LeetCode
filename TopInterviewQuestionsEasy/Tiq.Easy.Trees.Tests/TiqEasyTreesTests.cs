using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace Tiq.Easy.Trees.Tests
{
    public class TiqEasyTreesTests
    {
        private readonly ITestOutputHelper output;

        public TiqEasyTreesTests(ITestOutputHelper output) => this.output = output;

        [Fact]
        public void InitializesTreeCorrectly()
        {
            var root = InitializeTree(new int?[] { 1, 2, 3, 4, null, 5, 6, 7, 8, 9, 10, null, 11, null, null, 12, 13 });
            var queue = new Queue<TreeNode>();

            while (root != null)
            {
                output.WriteLine(root.val.ToString());

                if (root.left != null)
                {
                    queue.Enqueue(root.left);
                }

                if (root.right != null)
                {
                    queue.Enqueue(root.right);
                }

                root = queue.Count > 0 ? queue.Dequeue() : null;
            }
        }

        [Fact]
        public void MaxDepth3Correct()
        {
            var root = InitializeTree(new int?[] { 3, 9, 20, null, null, 15, 7 });
            var expected = 3;

            var actual = new MaximumDepth().MaxDepth(root);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MaxDepthTest5Correct()
        {
            var root = InitializeTree(new int?[] { 1, 2, 3, 4, null, 5, 6, 7, 8, 9, 10, null, 11, null, null, 12, 13 });
            var expected = 5;

            var actual = new MaximumDepth().MaxDepth(root);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsValidBst3False()
        {
            var root = InitializeTree(new int?[] { 3, 9, 20, null, null, 15, 7 });
            Assert.False(new ValidateTree().IsValidBST(root));
        }

        [Fact]
        public void IsValidBst4True()
        {
            var root = InitializeTree(new int?[] { 7, 2, 8, 1, 3, null, 9, null, null, null, 4 });
            Assert.True(new ValidateTree().IsValidBST(root));
        }

        [Fact]
        public void IsValidBstLeetCodeFalse()
        {
            var root = InitializeTree(new int?[] { 10, 5, 15, null, null, 6, 20 });
            Assert.False(new ValidateTree().IsValidBST(root));
        }

        [Fact]
        public void IsSymmetricTrue()
        {
            var root = InitializeTree(new int?[] { 1, 2, 2, 3, 4, 4, 3 });
            Assert.True(new SymmetricTree().IsSymmetric(root));
        }

        [Fact]
        public void IsSymmetricFalse()
        {
            var root = InitializeTree(new int?[] { 1, 2, 2, null, 3, null, 3 });
            Assert.False(new SymmetricTree().IsSymmetric(root));
        }

        private TreeNode InitializeTree(int?[] values)
        {
            var current = 0;

            TreeNode root =
                values != null &&
                current < values.Length &&
                values[current].HasValue
                    ? new TreeNode(values[current++].Value)
                    : null;
            
            var node = root;
            var queue = new Queue<TreeNode>();

            while (node != null)
            {
                var left = current < values.Length ? values[current++] : null;
                var right = current < values.Length ? values[current++] : null;

                if (left.HasValue)
                {
                    node.left = new TreeNode(left.Value);
                    queue.Enqueue(node.left);
                }

                if (right.HasValue)
                {
                    node.right = new TreeNode(right.Value);
                    queue.Enqueue(node.right);
                }

                node = queue.Count > 0 ? queue.Dequeue() : null;
            }

            return root;
        }
    }
}

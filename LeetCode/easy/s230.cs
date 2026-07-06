using LeetCode.supportClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    internal class KthSmallestElementInBST
    {
        public static int Solution(TreeNode root, int k)
        {
            return Dfs(root, ref k);
        }

        private static int Dfs(TreeNode node, ref int k)
        {
            if (node == null)
                return -1;

            int left = Dfs(node.left, ref k);
            if (left != -1)
                return left;

            if (--k == 0)
                return node.val;

            return Dfs(node.right, ref k);
        }
    }
}

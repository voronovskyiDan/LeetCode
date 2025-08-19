using LeetCode.supportClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    class InvertBinaryTree
    {
        public TreeNode Solution(TreeNode root)
        {
            if (root == null) return null;

            TreeNode node = root.left;
            root.left = root.right;
            root.right = node;

            Solution(root.left);
            Solution(root.right);

            return root;
        }
    }
}

using LeetCode.supportClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    class MaximumDepthOfBinaryTree
    {
        public static int Solution(TreeNode root)
        {
            /*if (root == null)
                return 0;
            
            return goDeep(root, 1);*/

            if (root == null)
            {
                return 0;
            }

            int left = Solution(root.left);
            int right = Solution(root.right);

            return 1 + Math.Max(left, right);
        }

        private static int goDeep(TreeNode root, int depth)
        {
            int l = 0, r = 0;

            if (root.left != null)
                l = goDeep(root.left, depth + 1);
            if (root.right != null)
                r = goDeep(root.right, depth + 1);
            if (root.left == null && root.right == null)
                return depth;
            return Math.Max(l, r);
        }

    }
}

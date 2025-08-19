using LeetCode.supportClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    class SymetricTree
    {
        public static bool Solution(TreeNode root)
        {
            if (root == null) return true;
            return Solution(root.left, root.right);
        }

        public static bool Solution(TreeNode l, TreeNode r)
        {
            if (l == null && r == null)
                return true;
            if (l == null || r == null)
                return false;

            if (l.val != r.val)
                return false;

            return Solution(l.left,r.right) && Solution(l.right,r.left);
        }
    }
}

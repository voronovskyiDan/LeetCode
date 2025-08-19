using LeetCode.supportClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    class PathSum
    {
        public static bool Solution(TreeNode root, int targetSum)
        {
            if (root == null )
                return false;
            if (targetSum - root.val == 0 && root.left == null && root.right == null)
                return true;
            
            return Solution(root.left, targetSum-root.val) || Solution(root.right, targetSum - root.val);
        }
    }
}

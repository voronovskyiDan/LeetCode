using LeetCode.supportClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    class MinimumAbsoluteDifferenceInBST
    {
        private int min = int.MaxValue;
        private int? prev = null;

        public int Solution(TreeNode root)
        {
            if (root == null) return min;

            Solution(root.left);

            if(prev != null)
            {
                min = Math.Min(min, root.val - prev.Value);
            }
            prev = root.val;

            Solution(root.right);

            return min;
        }
    }
}

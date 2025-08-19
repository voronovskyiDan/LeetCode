using LeetCode.supportClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    class SameTree
    {
        public bool Solution(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;
            else if((p == null && q != null) || (p != null && q == null))
                return false;

            if (p.val != q.val)
                return false;

            return Solution(p.left,q.left) && Solution(p.right,q.right);
        }
    }
}

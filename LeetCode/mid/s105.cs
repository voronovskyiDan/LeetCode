using LeetCode.supportClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
    class ConstructBinaryTree
    {
        private static int preIndex = 0;
        public static TreeNode Solution(int[] preorder, int[] inorder)
        {
            if (preorder.Length == 0) return null;
            Dictionary<int, int> map = new();
            for (int i = 0; i < inorder.Length; i++)
            {
                map.Add(inorder[i], i);
            }

            return build(preorder, 0, inorder.Length - 1, map);
        }
        public static TreeNode build(int[] preorder, int subStart, int subEnd, Dictionary<int, int> map)
        {
            if (subStart > subEnd) return null;

            int rootVal = preorder[preIndex++];
            TreeNode node = new TreeNode(rootVal);

            int inIndex = map[rootVal];

            node.left = build(preorder, subStart, inIndex - 1, map);
            node.right = build(preorder, inIndex + 1, subEnd, map);
            return node;
        }
    }
}

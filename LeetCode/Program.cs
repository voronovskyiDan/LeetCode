using LeetCode.easy;
using LeetCode.mid;
using LeetCode.supportClasses;

namespace LeetCode;

internal class Program
{
    static void Main(string[] args)
    {
        TreeNode root = new(1, null, new TreeNode(2,null,null));
        int res = MaximumDepthOfBinaryTree.Solution(root);
        Console.WriteLine(res);
    }
}
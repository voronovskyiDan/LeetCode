using LeetCode.easy;
using LeetCode.mid;
using LeetCode.supportClasses;

namespace LeetCode;

internal class Program
{
    static void Main(string[] args)
    {
        bool res = SymetricTree.Solution(new TreeNode(1,
            new TreeNode(2, new TreeNode(4,null,null), new TreeNode(3, null, null)),
            new TreeNode(2, new TreeNode(3, null, null), new TreeNode(4, null, null))));
        Console.WriteLine(res);
    }
}
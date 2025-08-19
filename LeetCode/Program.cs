using LeetCode.easy;
using LeetCode.mid;
using LeetCode.supportClasses;

namespace LeetCode;

internal class Program
{
    static void Main(string[] args)
    {
        int res = MinimumSizeSubarraySum.Solution(7, new int[] { 2, 3, 1, 2, 4, 3 });
        Console.WriteLine(res);
    }
}
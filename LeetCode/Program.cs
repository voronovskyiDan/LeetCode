using LeetCode.easy;
using LeetCode.mid;

namespace LeetCode;

internal class Program
{
    static void Main(string[] args)
    {
        int res = LongestConsecutiveSequence.Solution(new int[] { 100, 4, 200, 1, 3, 2 });

        Console.WriteLine(res);
    }
}
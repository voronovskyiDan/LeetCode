using LeetCode.easy;
using LeetCode.mid;

namespace LeetCode;

internal class Program
{
    static void Main(string[] args)
    {
        IList<string> res = SummaryRanges.Solution(new int[] { 0, 2, 3, 4, 6, 8, 9 });

        foreach(var it in res)
        {
            Console.Write(it + " ");
        }
    }
}
using LeetCode.easy;
using LeetCode.mid;

namespace LeetCode;

internal class Program
{
    static void Main(string[] args)
    {
        int[][] res = MergeIntervals.Solution(new int[][] {
                new int[] { 1, 3 },
                new int[] { 2, 6 },
                new int[] { 8, 10 },
                new int[] { 15, 18 }
            });

        foreach(var group in res)
        {
            foreach(var it in group)
            {
                Console.Write(it + " ");
            }
            Console.WriteLine();
        }
    }
}